namespace Arian_project
{
    public class Card_Reader
    {
        public int id {  get; set; }

        public string name { get; set; }

        public int bank_id { get; set; }

        public Card_Reader(int id, string name, int bank_id)
        {
            this.id = id;
            this.name = name;
            this.bank_id = bank_id;
        }
    }
}
