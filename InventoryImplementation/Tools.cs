using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CAP_Inventory_System;
using Data_Base_MNG;
using PANDA_TOOLS;
using System.Data;

namespace InventoryImplementation
{
    class Tools
    {
        public void Load_tags_From_CSV(ref Inventory_System_API x,string path)
        {
            CDF_to_DataTable y = new CDF_to_DataTable(',', path, true);
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
        public void Load_Tags_From_SQL(ref Inventory_System_API x)
        {
            //SQL DBMNG = new SQL("FSSERV", "FSDBMR", "AmalAdmin", "Amalgamma16");

            CAPA_INVContext context = new CAPA_INVContext();
            SQL DBMNG = context.DB_MNG_FS;

            DataTable TicketTags = new DataTable();
            List<TicketTag> L = new List<TicketTag>();

            string _query = @"select * from [FSDBMR].[dbo].[_CAP_INV_SYS_TicketCount_Tag]";

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
            context.Dispose();
        }
        public void Load_Tags_From_Random(ref Inventory_System_API x, int No_Tags)
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
        public void Load_MOtags_From_CSV(ref Inventory_System_API x, string path)
        {
            CDF_to_DataTable y = new CDF_to_DataTable(',', path, true);
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
        public void Load_MOTags_From_SQL(ref Inventory_System_API x)
        {
            //SQL DBMNG = new SQL("FSSERV", "FSDBMR", "AmalAdmin", "Amalgamma16");

            CAPA_INVContext context = new CAPA_INVContext();
            SQL DBMNG = context.DB_MNG_FS;

            DataTable TicketMOTags = new DataTable();
            List<MOTag> L = new List<MOTag>();
            MOTag MOTag2Save = new MOTag();
            MOTag MOTag2Compare = new MOTag();

            string _query = @"SELECT * FROM [FSDBMR].[dbo].[_CAP_AC_MOTAGS] ORDER BY MOHeaderKey, MOLineKey ";

            TicketMOTags = DBMNG.Execute_Query(_query);
            int MOTagHeaderID = 0;

            foreach (DataRow R in TicketMOTags.Rows)
            {
                MOTag2Compare = MOTagLogic.DataRow2MOTag(R);
                MOTagLine _moTagLine = new MOTagLine();
                if ((MOTag2Save.MO != MOTag2Compare.MO) || (MOTag2Save.MO_Ln != MOTag2Compare.MO_Ln))
                {
                    MOTag2Save = MOTag2Compare;
                    int counter = x.CreateMOHeaderTag(MOTag2Save);
                    MOTag2Compare = x.LoadMOHeaderTag(counter);
                    MOTagHeaderID = MOTag2Compare.MOTagID;
                }
                _moTagLine = MOTagLineLogic.DataRow2MOTagLine(R);
                _moTagLine.MOTagID = MOTagHeaderID;
                x.CreateMOTagLine(_moTagLine);

                //L.Add(MOTagLogic.DataRow2MOTag(R));

                //x.CreateCountTiket(TicketTagLogic.DataRow2Tag(R));
            }
            //for (int j = 0; j < L.Count; j++)
            //{
            //    x.CreateMOHeaderTag(L[j]);
            //}
            context.Dispose();
        }
    }
}
