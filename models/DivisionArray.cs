using System;
using System.Collections.Generic;
using System.Text;

namespace models {
    public class DivisionArray {
        private Division[] records = new Division[20];
        private int currPosition = 0;

        // CRUD
        public void AddRecord(string newDivision) {
            Division newRecord = new Division();
            newRecord.Id = this.getNextDivisionId();
            newRecord.DivisionName = newDivision;
            this.records[this.currPosition] = newRecord;
            this.currPosition++;
        }


        private int getNextDivisionId() {
            return this.currPosition+1;
        }
    }
}
