using System;
using System.Collections.Generic;
using System.Text;

namespace models {
    public class CategoriesArray {
        private Category[] records = new Category[20];
        private int currPosition = 0;
        public void AddRecord(string newCategory) {
            Category newRecord = new Category();
            if (newRecord.SetId(getNextDivisionId())) {
                newRecord.SetName(newCategory);
                this.records[this.currPosition] = newRecord;
                this.currPosition++;
            }
            
        }
        public string ReadRecord(int recordId) {
            return this.records[recordId].GetName();
        }

        private int getNextDivisionId() {
            return this.currPosition + 1;
        }
    }
}
