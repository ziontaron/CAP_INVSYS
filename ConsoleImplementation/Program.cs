using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using CAP_Inventory_System;
using Data_Base_MNG;
using PANDA_TOOLS;
using Data_Base_MNG;

namespace ConsoleImplementation
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory_System_API x = new Inventory_System_API("RC IE");
            SQL DB_MNG = new SQL("RSSERVER", "CAPA_INV", "inv_sys", "Capsonic2017!");
            //Inventory_System_API x = new Inventory_System_API("Otro");
            //Inventory_System_API x = new Inventory_System_API(4);
            //Inventory_System_API x = new Inventory_System_API();
            //x.CreateInventoryEvent("TEST", "Test");

            string q = @"SELECT Ticket.TicketCounter, TicketCount.TagCountKey, TicketCount.CounterInitials, TicketCount.CountedDate, TicketCount.TicketKey, TicketCount.ItemNumber, TicketCount.ItemDescription, 
                      TicketCount.ItemRef, TicketCount.UM, TicketCount.LotNumber, TicketCount.CountQTY, TicketCount.ReCountQty, TicketCount.InventoryQty, TicketCount.BIN, TicketCount.IC, TicketCount.Verified, 
                      TicketCount.BlankTag, TicketCount.VoidTag, TicketCount.ItemNumber_FSKey, TicketCount.STK, FS_ItemMaster.FS_ItemMaster_Key
                        FROM Ticket INNER JOIN
                      TicketCount ON Ticket.TicketKey = TicketCount.TicketKey INNER JOIN
                      FS_ItemMaster ON TicketCount.ItemNumber = FS_ItemMaster.ItemNumber
                        WHERE(TicketCount.ItemNumber_FSKey = 0) AND(TicketCount.VoidTag = 0) OR
                (TicketCount.ItemNumber_FSKey IS NULL)
                      order by Ticket.TicketCounter";

            string _q = @"SELECT Ticket.TicketCounter, TicketCount.TagCountKey, TicketCount.CounterInitials, TicketCount.CountedDate, TicketCount.TicketKey, TicketCount.ItemNumber, TicketCount.ItemDescription, 
                      TicketCount.ItemRef, TicketCount.UM, TicketCount.LotNumber, TicketCount.CountQTY, TicketCount.ReCountQty, TicketCount.InventoryQty, TicketCount.BIN, TicketCount.IC, TicketCount.Verified, 
                      TicketCount.BlankTag, TicketCount.VoidTag, TicketCount.ItemNumber_FSKey, TicketCount.STK, FS_ItemMaster.FS_ItemMaster_Key, FS_ItemMaster.ItemNumber_FSKey AS FS_ItemM_CostKey
                        FROM Ticket INNER JOIN
                      TicketCount ON Ticket.TicketKey = TicketCount.TicketKey INNER JOIN
                      FS_ItemMaster ON TicketCount.ItemNumber = FS_ItemMaster.ItemNumber
                      WHERE TicketCount.ItemNumber_FSKey <> FS_ItemMaster.ItemNumber_FSKey";
            
            DataTable T= DB_MNG.Execute_Query(_q);

            for (int i = 0; i < T.Rows.Count; i++)
            {
                string update = @"UPDATE [CAPA_INV].[dbo].[TicketCount]
                     SET [ItemNumber_FSKey] = " + T.Rows[i]["FS_ItemM_CostKey"].ToString() + " WHERE TagCountKey="+ T.Rows[i]["TagCountKey"].ToString();

                DB_MNG.Execute_Command(update);

            }
            //TicketTag z = new TicketTag();
            //int tag = 0;
            //z = x.LoadTag(tag);
        }
        static void load_tags_from_CSV(ref Inventory_System_API x)
        {
            CDF_to_DataTable y = new CDF_to_DataTable(',', "tags.csv", true);
            DataTable TicketTags = new DataTable();
            List<TicketTag> L = new List<TicketTag>();
            TicketTags = y.Start_Conversion();
            foreach (DataRow R in TicketTags.Rows)
            {
                //L.Add(TicketTagLogic.DataRow2Tag(R));                
                L.Add(Inventory_System_API.TicketTag_DataRow2Tag(R));
            }
            for (int j = 0; j < L.Count; j++)
            {
                x.CreateCountTiket(L[j]);
            }
        }
        static void Load_Tags_From_SQL(ref Inventory_System_API x)
        {
            SQL DBMNG = new SQL("FSSERV", "FSDBMR", "AmalAdmin", "Amalgamma16");
            DataTable TicketTags = new DataTable();
            List<TicketTag> L = new List<TicketTag>();

            string _query = @"SELECT 
                row_number() over (order by FS_Item.ItemNumber) AS [Counter]
                ,  FS_Item.ItemNumber
                , FS_Item.ItemDescription
                , FS_Item.ItemReference1
                , FS_Item.ItemUM
                , FS_ItemInventory.Stockroom
                , FS_ItemInventory.Bin
                , FS_ItemInventory.InventoryCategory
                , FS_ItemInventory.InventoryQuantity
                , FS_ItemInventory.LotNumber

                FROM         FS_Item INNER JOIN FS_ItemInventory ON FS_Item.ItemKey = FS_ItemInventory.ItemKey
                WHERE (FS_ItemInventory.Stockroom <> 'TC') AND (FS_ItemInventory.Stockroom <> 'OBS')
                order by FS_Item.ItemNumber";

            TicketTags = DBMNG.Execute_Query(_query);

            foreach (DataRow R in TicketTags.Rows)
            {
                L.Add(TicketTagLogic.DataRow2Tag(R));

                //x.CreateCountTiket(TicketTagLogic.DataRow2Tag(R));
            }
            for (int j = 0; j < L.Count; j++)
            {
                x.CreateCountTiket(L[j]);
            }
        }
        static void Load_Tags_From_Random(ref Inventory_System_API x,int No_Tags)
        {
            DataTable TicketTags = new DataTable();
            List<TicketTag> L = new List<TicketTag>();
            Random r = new Random();
            TicketTags.Columns.Add("Counter", typeof(int));
            TicketTags.Columns.Add("ItemNumber", typeof(string));
            TicketTags.Columns.Add("ItemDescription", typeof(string));
            TicketTags.Columns.Add("ItemReference1", typeof(string));
            TicketTags.Columns.Add("ItemUM", typeof(string));
            TicketTags.Columns.Add("Stockroom", typeof(string));
            TicketTags.Columns.Add("Bin", typeof(string));
            TicketTags.Columns.Add("InventoryCategory", typeof(string));
            TicketTags.Columns.Add("InventoryQuantity", typeof(int));
            TicketTags.Columns.Add("LotNumber", typeof(string));

            string[] SKT = { "FG", "JZ", "3", "J", "NO" };
            string[] BIN = { "01", "02", "03", "04", "05", "NORTH", "BIN", "B", "QC", "J01", "NORTH" };
            string[] IC = { "O", "H", "I" };

            int last_tag = x.GetLastCounter();
            for (int i = 1; i < No_Tags; i++)
            {
                TicketTags.Rows.Add(i + last_tag, "201100", "Test Part", "87", "EA"
                    , SKT[r.Next(0, SKT.Count())]
                    , BIN[r.Next(0, BIN.Count())]
                    , IC[r.Next(0, IC.Count())]
                    , r.Next(1, 512)
                    , "TestLot-" + r.Next(1, 365).ToString());
            }
            foreach (DataRow R in TicketTags.Rows)
            {
                L.Add(TicketTagLogic.DataRow2Tag(R));
            }
            for (int j = 0; j < L.Count; j++)
            {
                x.CreateCountTiket(L[j]);
            }
        }

        #region MO Tags
        static void load_MOtags_from_CSV(ref Inventory_System_API x)
        {
            CDF_to_DataTable y = new CDF_to_DataTable(',', "MO tags Headers.csv", true);
            DataTable MOTags = new DataTable();
            List<MOTag> L = new List<MOTag>();
            MOTags = y.Start_Conversion();
            
            foreach (DataRow R in MOTags.Rows)
            {
                //L.Add(TicketTagLogic.DataRow2Tag(R));                
                L.Add(Inventory_System_API.MOTag_DataRow2Tag(R));
            }

            //x.CreateMOHeaderTag(L[0]);
            for (int j = 0; j < L.Count; j++)
            {
                x.CreateMOHeaderTag(L[j]);
            }
        }
        #endregion

        static void Simulate_Capture(ref Inventory_System_API x, int Cicles)
        {
            int LastCounter = x.GetLastCounter();
            Random r = new Random();
            int counter = 0;
            TicketTag z = new TicketTag();
            string[] Contadores = { "AC", "AB", "AC", "JL", "GV", "GH" };
            Console.WriteLine("Start Simulate Capture");

            while (counter < Cicles)
            {
                int rTag = r.Next(LastCounter);
                z = x.LoadTag(rTag);
                try
                {
                    if (!z.Verified)
                    {
                        int max = Convert.ToInt32(z.InventoryQuantity);
                        z.CountQTY = r.Next(max + r.Next(5));
                        z.ReCountQTY = r.Next(max + r.Next(5));
                        z.Verified = true;
                        z.CounterInitials = Contadores[r.Next(Contadores.Count())];
                        z.CountedDate = DateTime.Now;
                        x.UpdateTag(z);
                        counter++;

                        Console.WriteLine("Ticket Tag Captured: " + rTag.ToString());
                    }
                }
                catch
                { }
            }
            Console.WriteLine("Finish Simulate Capture # of Captured Tags: " + Cicles.ToString());


        }
    }

    }
