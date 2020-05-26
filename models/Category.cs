using System;
using System.Collections.Generic;
using System.Text;

namespace models {
    class Category {
        private int recordId;
        private string RecordName;
        private int divisionId;

        public int GetId() {
            return this.recordId;
        }
        public bool SetId(int id) {
            bool ret = false;
            if(id > 0) {
                this.recordId = id;
                ret = true;
            }
            return ret;
        }
        public string GetName() {
            return this.RecordName;
        }
        public void SetName(string newName) {
            this.RecordName = newName;
        }
    }
}
