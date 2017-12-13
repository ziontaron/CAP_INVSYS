using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAP_Inventory_System
{
    public partial class Inventory_System_API
    {
        public DataTable ReadAllFSTI_Transactions()
        {
            DataTable T = new DataTable();
            #region Table Setup
            T.Columns.Add("InventoryEventKey", typeof(string));
            T.Columns.Add("FSTI_Transaction_key", typeof(int));
            T.Columns.Add("TagCountKey", typeof(int));
            T.Columns.Add("FS_PartNo", typeof(string));
            T.Columns.Add("InventoryEventName", typeof(string));
            T.Columns.Add("TicketCounter", typeof(string));
            T.Columns.Add("TransactionType", typeof(string));
            T.Columns.Add("TransactionStringFields", typeof(string));
            T.Columns.Add("TransactionProcessedYN", typeof(bool));
            T.Columns.Add("FSResponse", typeof(string));
            T.Columns.Add("FSError", typeof(bool));
            T.Columns.Add("DateStampIn", typeof(DateTime));
            T.Columns.Add("DateStampOut", typeof(DateTime));
            #endregion

            List<V_FSTI_Transaction> LT = _V_FSTI_TransactionLogic.ReadAll(ActiveEventId);

            foreach (V_FSTI_Transaction fsti in LT)
            {
                T.Rows.Add(
                    fsti.InventoryEventKey
                    , fsti.FSTI_Transaction_key
                    , fsti.TagCountKey
                    , fsti.FS_PartNo
                    , fsti.InventoryEventName
                    , fsti.TicketCounter
                    , fsti.TransactionType
                    , fsti.TransactionStringFields
                    , fsti.TransactionProcessedYN
                    , fsti.FSResponse
                    , fsti.FSError
                    , fsti.DateStampIn
                    , fsti.DateStampOut
                    );
            }
            return T;
        }
        
    }
}
