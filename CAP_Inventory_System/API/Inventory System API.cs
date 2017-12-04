using System.Collections.Generic;
using CAP_Inventory_System.Logic;
using System.Data;
using Reusable;
using System;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        #region Constructors
        public Inventory_System_API() { }
        public Inventory_System_API(int EventId) { ReadInventoryEventById(EventId); }
        public Inventory_System_API(string EventName) { ReadInventoryEventByName(EventName); }
        #endregion

        #region Public Properties
        public int ActiveEventId
        {
            get
            {
                try
                {
                    return _ActiveInventoryEvent.InventoryEventKey;
                }
                catch
                {
                    return -1;
                }
            }
        }
        public string ActiveEventName
        {
            get
            {
                try
                {
                    return _ActiveInventoryEvent.InventoryEventName;
                }
                catch
                {
                    return "";
                }
            }
        }
        public string ActiveEventDescription
        {
            get
            {
                try
                {
                    return _ActiveInventoryEvent.InventoryEventDescription;
                }
                catch
                {
                    return "";
                }
            }
        }
        public bool ActiveEventStatus
        {
            get
            {
                try
                {
                    return _ActiveInventoryEvent.Status;
                }
                catch
                {
                    return false;
                }
            }
        }
        public int ActiveEventQtyofTags
        {
            get
            {
                try
                {
                    return QTYofTags(ActiveEventId);
                }
                catch
                {
                    return 0;
                }
            }
        }
        public DateTime ActiveEventCreationDate
        {
            get
            {
                try
                {
                    return _ActiveInventoryEvent.CreationDate;
                }
                catch
                {
                    return DateTime.Now;
                }

            }
        }
        #endregion

        #region Entities
        CommonResponse _Response;
        InventoryEvent _ActiveInventoryEvent;
        #endregion

        #region Entities_Logic
        InventoryEventLogic _inventoryEventLogic = new InventoryEventLogic();
        TicketLogic _ticketLogic = new TicketLogic();
        TicketCountLogic _ticketCountLogic = new TicketCountLogic();
        cat_TicketTypeLogic _cat_TicketTypeLogic = new cat_TicketTypeLogic();
        cat_UserRoleLogic _cat_UserRoleLogic = new cat_UserRoleLogic();
        MOTagHeaderLogic _moTagHeaderLogic = new MOTagHeaderLogic();
        MOTagCountLogic _moTagCountLogic = new MOTagCountLogic();
        FS_ItemMasterLogic _FS_ItemMasterLogic = new FS_ItemMasterLogic();
        FSTI_TransactionLogic _FSTI_TransactionLogic = new FSTI_TransactionLogic();
        #endregion

        #region Private Properties
        #endregion

        #region Public Properties
        public string ErrorMessage { get { return _Response.ResponseDescription; } }
        public bool ErrorOccour { get { return _Response.ErrorThrown; } }
        public string ErrorType { get { return _Response.ErrorType; } }
        public object Result { get { return _Response.Result; } }
        public object AditinalData { get { return _Response.AdditionalData; } }
        #endregion

        #region Private Functions
        #region EF Entity -> API Entity
        /// <summary>
        /// Converts a TicketCount enttity from EF to a TicketTag
        /// </summary>
        /// <param name="T"></param>
        /// <returns></returns>
        private TicketTag Entity2Tag(TicketCount T)
        {
            TicketTag _tag = new TicketTag();

            _tag.Counter = T.Ticket.TicketCounter;
            _tag.ItemNumber = T.ItemNumber;
            _tag.ItemDescription = T.ItemDescription;
            _tag.ItemReference1 = T.ItemRef;
            _tag.ItemUM = T.UM;
            _tag.Bin = T.BIN;
            _tag.Stockroom = T.STK;
            _tag.InventoryCategory = T.IC;
            _tag.InventoryQuantity = T.InventoryQty;
            _tag.LotNumber = T.LotNumber;

            _tag.CountQTY = T.CountQty;
            _tag.ReCountQTY = T.ReCountQty;
            _tag.Verified = T.Verified;
            _tag.BlankTag = T.BlankTag;
            _tag.VoidTag = T.VoidTag;
            _tag.CounterInitials = T.CounterInitials;
            _tag.CountedDate = T.CountedDate;

            _tag.TicketID = T.Ticket.TicketKey;
            _tag.TicketCountID = T.TagCountKey;
            _tag.EventID = T.Ticket.InventoryEventKey;

            return _tag;
        }
        /// <summary>
        /// Converts a MOTagHeader enttity from EF to a MOTag
        /// </summary>
        /// <param name="MOT"></param>
        /// <returns></returns>
        private MOTag Entity2MOTag(MOTagHeader MOT)
        {
            MOTag _MOtag = new MOTag();
            Ticket _t = (Ticket)_ticketLogic.ReadbyId(MOT.TicketKey).Result;
            _MOtag.Counter = _t.TicketCounter;
            _MOtag.Planner = MOT.Planner;
            _MOtag.MO = MOT.MO;
            _MOtag.MO_Ln = MOT.MO_Ln;
            _MOtag.MO_Status = MOT.MO_Status;
            _MOtag.LineType = MOT.LineType;
            _MOtag.Order_Qty = (int)MOT.Order_Qty;
            _MOtag.Recv_Qty = (int)MOT.Recv_Qty;
            _MOtag.FGinWip = (int)MOT.FG_Qty_in_WIP;

            _MOtag.Parent_Item_NO = MOT.Parent_Item_NO;
            _MOtag.Parent_Item_Desc = MOT.Parent_Item_Desc;
            _MOtag.Parent_ItemRef1 = MOT.Parent_ItemRef1;

            _MOtag.CountedDate = MOT.CountedDate;
            _MOtag.CounterInitials = MOT.CounterInitials;

            _MOtag.MOTagID = MOT.MOTagHeaderKey;
            _MOtag.TicketID = MOT.TicketKey;

            return _MOtag;
        }
        /// <summary>
        /// Converts a MOTagLine enttity from EF to a MOTag
        /// </summary>
        /// <param name="_t"></param>
        /// <returns></returns>
        private MOTagLine Entity2MOTagLine(MOTagCount _t)
        {
            MOTagLine MOTCount = new MOTagLine();

            MOTCount.SeqNum = _t.SeqNum;
            MOTCount.Component_No = _t.Component_No;
            MOTCount.Component_Desc = _t.Component_Desc;
            MOTCount.UM = _t.UM;
            MOTCount.Qty_Per = _t.Qty_Per;
            MOTCount.Issued_Qty = _t.Issued_Qty;
            MOTCount.LooseCountQty = _t.LooseCountQty;
            MOTCount.LooseReCountQty = _t.LooseReCountQty;
            MOTCount.MOTagLineID = _t.MOTagCountKey;
            MOTCount.MOTagID = _t.MOTagHeaderKey;

            return MOTCount;
        }
        #endregion

        #region API Entity -> EF Entity
        /// <summary>
        /// Converts a TicketTag to a EF TicketCount Enttity
        /// </summary>
        /// <param name="_tag"></param>
        /// <returns></returns>
        private TicketCount Tag2Entity(TicketTag _tag)
        {
            TicketCount T = new TicketCount();
            Ticket _T = new Ticket();

            T.Ticket = _T;

            T.Ticket.TicketCounter = _tag.Counter;
            T.ItemNumber = _tag.ItemNumber;
            T.ItemDescription = _tag.ItemDescription;
            T.ItemRef = _tag.ItemReference1;
            T.UM = _tag.ItemUM;
            T.BIN = _tag.Bin;
            T.STK = _tag.Stockroom;
            T.IC = _tag.InventoryCategory;
            T.InventoryQty = _tag.InventoryQuantity;
            T.LotNumber = _tag.LotNumber;

            T.CountQty = _tag.CountQTY;
            T.ReCountQty = _tag.ReCountQTY;
            T.Verified = _tag.Verified;
            T.BlankTag = _tag.BlankTag;
            T.VoidTag = _tag.VoidTag;
            T.CounterInitials = _tag.CounterInitials;
            T.CountedDate = _tag.CountedDate;

            T.ItemNumber_FSKey = _tag.ItemNumber_FSKey;
            T.TicketKey = _tag.TicketID;
            T.Ticket.TicketKey = _tag.TicketID;
            T.TagCountKey = _tag.TicketCountID;
            T.Ticket.InventoryEventKey = _tag.EventID;
            
            return T;
        }
        /// <summary>
        /// Converts a MOTag to a EF MOTagHeader Enttity
        /// </summary>
        /// <param name="MOT"></param>
        /// <returns></returns>
        private MOTagHeader MOTag2Entity(MOTag MOT)
        {
            Ticket T = new Ticket();
            T = (Ticket)_ticketLogic.ReadbyId(MOT.TicketID).Result;
            MOTagHeader _MOtag = new MOTagHeader();

            _MOtag.Ticket = T;

            _MOtag.Ticket.TicketCounter = MOT.Counter;
            _MOtag.Planner = MOT.Planner;
            _MOtag.MO = MOT.MO;
            _MOtag.MO_Ln = MOT.MO_Ln;
            _MOtag.MO_Status = MOT.MO_Status;
            _MOtag.LineType = MOT.LineType;
            _MOtag.Order_Qty = (int)MOT.Order_Qty;
            _MOtag.Recv_Qty = (int)MOT.Recv_Qty;
            _MOtag.FG_Qty_in_WIP = MOT.FGinWip;

            _MOtag.Parent_Item_NO = MOT.Parent_Item_NO;
            _MOtag.Parent_Item_Desc = MOT.Parent_Item_Desc;
            _MOtag.Parent_ItemRef1 = MOT.Parent_ItemRef1;

            _MOtag.CountedDate = MOT.CountedDate;
            _MOtag.CounterInitials = MOT.CounterInitials;

            _MOtag.TicketKey = MOT.TicketID;
            _MOtag.MOTagHeaderKey = MOT.MOTagID;
            return _MOtag;
        }
        /// <summary>
        /// Converts a MOTagLine to a EF MOTagHeader Enttity
        /// </summary>
        /// <param name="_t"></param>
        /// <returns></returns>
        private MOTagCount MOTagLine2Entity(MOTagLine _t)
        {
            MOTagCount MOTCount = new MOTagCount();

            MOTCount.SeqNum = _t.SeqNum;
            MOTCount.Component_No = _t.Component_No;
            MOTCount.Component_Desc = _t.Component_Desc;
            MOTCount.UM = _t.UM;
            MOTCount.Qty_Per = _t.Qty_Per;
            MOTCount.Issued_Qty = _t.Issued_Qty;
            MOTCount.LooseCountQty = _t.LooseCountQty;
            MOTCount.LooseReCountQty = _t.LooseReCountQty;
            MOTCount.MOTagCountKey = _t.MOTagLineID;
            MOTCount.MOTagHeaderKey = _t.MOTagID;
            
            return MOTCount;
        }
        #endregion
        #endregion

        #region Public Functions        
        public int GetLastCounter()
        {
            Ticket LastTag = new Ticket();
            LastTag.InventoryEventKey = ActiveEventId;
            LastTag = (Ticket)_ticketLogic.GetLastTagID(LastTag).Result;
            if (LastTag != null)
            {
                return LastTag.TicketCounter;
            }
            else
            {
                return 0;
            }
        }
        public void SetCategories()
        {
            CreateTicketType("TicketCount", "Ticket Count Tag");
            CreateTicketType("MOTag", "MO Header");
        }
        public static TicketTag TicketTag_DataRow2Tag(DataRow r)
        {
            TicketTag _tag = new TicketTag();
            _tag.Counter = Convert.ToInt32(r["Counter"].ToString());
            _tag.ItemNumber = r["ItemNumber"].ToString();
            _tag.ItemDescription = r["ItemDescription"].ToString();
            _tag.ItemReference1 = r["ItemReference1"].ToString();
            _tag.ItemUM = r["ItemUM"].ToString();
            _tag.Stockroom = r["Stockroom"].ToString();
            _tag.Bin = r["Bin"].ToString();
            _tag.InventoryCategory = r["InventoryCategory"].ToString();
            _tag.InventoryQuantity = float.Parse(r["InventoryQuantity"].ToString());
            _tag.LotNumber = r["LotNumber"].ToString();

            return _tag;
        }
        public static MOTag MOTag_DataRow2Tag(DataRow r)
        {
            MOTag _tag = new MOTag();
            _tag.Counter = Convert.ToInt32(r["Counter"].ToString());
            _tag.Planner = r["Planner"].ToString();
            _tag.MO = r["MONumber"].ToString();
            _tag.MO_Ln = r["MOLineNumberString"].ToString();
            _tag.MO_Status = r["MOLineStatus"].ToString();
            _tag.LineType = r["MOLineType"].ToString();

            _tag.Order_Qty = Convert.ToInt32(r["ItemOrderedQuantity"].ToString());
            _tag.Recv_Qty = Convert.ToInt32(r["ReceiptQuantity"].ToString());

            _tag.Parent_Item_NO = r["ItemNumber"].ToString();
            _tag.Parent_Item_Desc = r["ItemDescription"].ToString();
            _tag.Parent_ItemRef1 = r["ItemReference1"].ToString();
            
            return _tag;
        }
        public TicketCount Tag2TicketCount(TicketTag T)
        {
            TicketCount _ticket = new TicketCount();
            _ticket = Tag2Entity(T);
            TicketCountLogic _ticketLogic = new Logic.TicketCountLogic();
            _ticket = (TicketCount)_ticketLogic.ReadbyId(_ticket).Result;
            return _ticket;
        }
        public List<string> LoadEvents()
        {
            List<string> L = new List<string>();
            foreach (string t in ReadAllInventoryEvents())
            {
                L.Add(t);
            }
            return L;
        }

        public Stadisticts LoadStadistics()
        {
            Stadisticts stats = new Stadisticts();
            if (ActiveEventId > 0)
            {
                stats = _inventoryEventLogic.EventStadistics(ActiveEventId);
            }
            return stats;
        }
        public void testFunc()
        {
            //UserLogic _UserLogic = new UserLogic();
            //cat_UserRoleLogic _cat_UserRoleLogic = new cat_UserRoleLogic();
            //cat_UserRole _userRole = (cat_UserRole)(_cat_UserRoleLogic.ReadbyName(new cat_UserRole { UserRole = "SysAdmin" }).Result);
            //_UserLogic.Create(new User
            //{
            //    UserName = "acorrales",
            //    Password = "capsonic",
            //    UserRoleKey = _userRole.UserRoleKey
            //});
        }

        #endregion
    }    
}
