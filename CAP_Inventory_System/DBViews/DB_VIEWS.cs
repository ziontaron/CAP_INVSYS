using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    static class DB_VIEWS
    {
        #region V_FSTI_Transaction
        static string V_FSTI_Transaction_DROP_V = @"DROP VIEW [dbo].[V_FSTI_Transaction]";
        static string V_FSTI_Transaction_DROP_T = @"DROP TABLE [dbo].[V_FSTI_Transaction]";
        static string V_FSTI_Transaction_CREATE = @"
                      CREATE VIEW [dbo].[V_FSTI_Transaction] AS
                      SELECT InventoryEvent.InventoryEventName, Ticket.TicketCounter, FSTI_Transactions.FSTI_Transaction_key, FSTI_Transactions.TransactionType, FSTI_Transactions.TransactionStringFields, 
                      FSTI_Transactions.TransactionProcessedYN, FSTI_Transactions.FSResponse, FSTI_Transactions.FSError, FSTI_Transactions.DateStampIn, FSTI_Transactions.DateStampOut, 
                      FSTI_Transactions.FS_PartNo, FSTI_Transactions.TagCountKey, InventoryEvent.InventoryEventKey
                      FROM Ticket INNER JOIN
                      TicketCount ON Ticket.TicketKey = TicketCount.TicketKey INNER JOIN
                      InventoryEvent ON Ticket.InventoryEventKey = InventoryEvent.InventoryEventKey INNER JOIN
                      FSTI_Transactions ON TicketCount.TagCountKey = FSTI_Transactions.TagCountKey";
        #endregion
        #region V_FSTI_Transaction Properties
        public static string FSTI_Tran_Drop_V { get { return V_FSTI_Transaction_DROP_V; } }
        public static string FSTI_Tran_Drop_T { get { return V_FSTI_Transaction_DROP_T; } }
        public static string FSTI_Tran_CREATE { get { return V_FSTI_Transaction_CREATE; } }
        #endregion

        #region V_FinanceRep
        static string V_FinanceRep_DROP_V = @"DROP VIEW [dbo].[V_FinanceRep]";
        static string V_FinanceRep_DROP_T = @"DROP TABLE [dbo].[V_FinanceRep]";
        static string V_FinanceRep_CREATE = @"
                  CREATE VIEW [dbo].[V_FinanceRep] AS
                   SELECT InventoryEvent.InventoryEventName, RIGHT('0000000' + CAST(Ticket.TicketCounter AS NVARCHAR(10)), 5) AS TicketCounterStr, Ticket.TicketCounter, TicketCount.CounterInitials, TicketCount.CountedDate, TicketCount.ItemNumber, 
                  TicketCount.ItemDescription, TicketCount.ItemRef, TicketCount.UM, TicketCount.LotNumber, TicketCount.CountQTY, TicketCount.ReCountQty, TicketCount.InventoryQty, 
                  (CASE 
                  WHEN (TicketCount.ReCountQty > 0) 
                  THEN(
					  CASE
					  WHEN (TicketCount.ReCountQty - TicketCount.InventoryQty) > 0 THEN '+' 
					  WHEN (TicketCount.ReCountQty - TicketCount.InventoryQty) < 0 THEN '-' 
					  ELSE '=' 
					  END
					  )
				  ELSE
				  (
					  CASE
					  WHEN (TicketCount.CountQTY - TicketCount.InventoryQty) > 0 THEN '+' 
					  WHEN (TicketCount.CountQTY - TicketCount.InventoryQty) < 0 THEN '-' 
					  ELSE '=' 
					  END
				  )
					END  ) AS UpDown
                  , (CASE 
                  WHEN (TicketCount.ReCountQty > 0) 
                  THEN 
					  CASE WHEN (TicketCount.ReCountQty - TicketCount.InventoryQty) < 0 
					  THEN ((TicketCount.ReCountQty - TicketCount.InventoryQty) * - 1) 
					  ELSE (TicketCount.ReCountQty - TicketCount.InventoryQty) 
					  END                   
                  WHEN (TicketCount.CountQTY <> 0) 
                  THEN 
					  CASE 
					  WHEN (TicketCount.CountQTY - TicketCount.InventoryQty) < 0 
					  THEN ((TicketCount.CountQTY - TicketCount.InventoryQty) * - 1) 
					  ELSE (TicketCount.CountQTY - TicketCount.InventoryQty) 
					  END 
                  WHEN (TicketCount.CountQTY = 0) 
                  THEN TicketCount.InventoryQty 
                  ELSE 0 
                  END) AS AbsBalance
                  
                  , (CASE WHEN (TicketCount.ReCountQty > 0) 
					THEN TicketCount.ReCountQty - TicketCount.InventoryQty 
                  WHEN (TicketCount.CountQTY <> 0) 
					THEN TicketCount.CountQTY - TicketCount.InventoryQty 
                  WHEN (TicketCount.CountQTY = 0) 
					THEN TicketCount.CountQTY - TicketCount.InventoryQty 
				  ELSE 0 END) AS Balance
				  , TicketCount.STK, TicketCount.BIN, TicketCount.IC, TicketCount.Verified, TicketCount.BlankTag, TicketCount.VoidTag, 
                  FS_ItemMaster.TotalRolledCost
                  ,InventoryEvent.InventoryEventKey
                FROM FS_ItemMaster INNER JOIN
                  InventoryEvent INNER JOIN
                  Ticket ON InventoryEvent.InventoryEventKey = Ticket.InventoryEventKey INNER JOIN
                  TicketCount ON Ticket.TicketKey = TicketCount.TicketKey ON FS_ItemMaster.ItemNumber_FSKey = TicketCount.ItemNumber_FSKey
";
        #endregion
        #region V_FinanceRep Properties
        public static string FinanceRep_Drop_V { get { return V_FinanceRep_DROP_V; } }
        public static string FinanceRep_Drop_T { get { return V_FinanceRep_DROP_T; } }
        public static string FinanceRep_CREATE { get { return V_FinanceRep_CREATE; } }
        #endregion

        #region v_MOTags
        static string v_MOTags_DROP_V = @"DROP VIEW [dbo].[v_MOTags]";
        static string v_MOTags_DROP_T = @"DROP TABLE [dbo].[v_MOTags]";
        static string v_MOTags_CREATE = @"
                  CREATE VIEW [dbo].[v_MOTags] AS
                SELECT TOP (100) PERCENT dbo.Ticket.TicketCounter, dbo.InventoryEvent.InventoryEventName, dbo.MOTagHeader.Planner, dbo.MOTagHeader.MO, dbo.MOTagHeader.MO_Ln, 
                 dbo.MOTagHeader.MO_Status, dbo.MOTagHeader.Order_Qty, dbo.MOTagHeader.LineType, dbo.MOTagHeader.Recv_Qty, dbo.MOTagHeader.Parent_Item_NO, dbo.MOTagHeader.Parent_Item_Desc, 
                 dbo.MOTagHeader.Parent_ItemRef1, dbo.MOTagHeader.CounterInitials, dbo.MOTagHeader.CountedDate, dbo.MOTagHeader.FG_Qty_in_WIP, dbo.MOTagCount.SeqNum, dbo.MOTagCount.UM, 
                 dbo.MOTagCount.Component_No, dbo.MOTagCount.Component_Desc, dbo.MOTagCount.Qty_Per, dbo.MOTagCount.Issued_Qty, dbo.MOTagCount.LooseCountQty, 
                 dbo.MOTagCount.LooseReCountQty
                FROM dbo.Ticket INNER JOIN
                 dbo.InventoryEvent ON dbo.Ticket.InventoryEventKey = dbo.InventoryEvent.InventoryEventKey INNER JOIN
                 dbo.MOTagHeader ON dbo.Ticket.TicketKey = dbo.MOTagHeader.TicketKey INNER JOIN
                 dbo.MOTagCount ON dbo.MOTagHeader.MOTagHeaderKey = dbo.MOTagCount.MOTagHeaderKey
                ORDER BY dbo.Ticket.TicketCounter, dbo.MOTagHeader.MO, dbo.MOTagHeader.MO_Ln, dbo.MOTagCount.SeqNum";
        #endregion
        #region v_MOTags Properties
        public static string MOTags_Drop_V { get { return v_MOTags_DROP_V; } }
        public static string MOTags_Drop_T { get { return v_MOTags_DROP_T; } }
        public static string MOTags_CREATE { get { return v_MOTags_CREATE; } }
        #endregion
    }
}
