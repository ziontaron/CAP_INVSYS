using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        public void Attach_FSTI_Transacion(TicketCount e,string DocNum,string InvAccount, string ReasonCode, string Remark)
        {
            FSTI_Transactions T = new FSTI_Transactions();

            T.TransactionType = "INVA";
            T.TagCountKey = e.TagCountKey;
            #region FSTI String Field

            //Item, Stk, Bin, Ic, DocNum, AC, Adj_Qty, RC, InvOffAcc, UM, LotNo, Remark
            //   0,   1,   2,  3,      4,  5,       6,  7,         8,  9,    10,     11

            //float balanceQty = 0;
            string ActionCode = "";
                        
            if (e.Balance > 0)
            {
                ActionCode = "+";
            }
            else
            {
                ActionCode = "-";
            }

            string Fields = "";

            Fields += e.ItemNumber + ",";
            Fields += e.STK + ",";
            Fields += e.BIN + ",";
            Fields += e.IC + ",";
            Fields += DocNum + ",";
            Fields += ActionCode + ",";
            Fields += Math.Abs(e.Balance).ToString() + ",";
            Fields += ReasonCode + ",";
            Fields += InvAccount + ",";
            Fields += e.UM + ",";
            Fields += e.LotNumber + ",";
            Fields += Remark;
            #endregion

            T.TagCountKey = e.TagCountKey;
            T.FS_PartNo = e.ItemNumber;
            T.TransactionStringFields = Fields;

            _FSTI_TransactionLogic.Create(T);
        }
        public void Update_FSTI_Transaction(FSTI_Transactions T)
        {
            _FSTI_TransactionLogic.Update(T);
        }
              
    }
}
