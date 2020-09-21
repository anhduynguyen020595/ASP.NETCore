namespace Indexer
{
    public class IndexerExam
    {
        string lastName = "Nguyen";
        string firstName = "Duy";

        public string this[int index]{
            get{
                if(index == 0) return lastName;
                else if(index == 1) return firstName;
                else throw new System.Exception("Not found the index!");
            }
            set{
                if(index == 0) this.lastName = value;
                else if(index ==  1) this.firstName = value;
                else throw new System.Exception("Not found the index!");
            }
        }
    }
}