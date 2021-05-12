namespace FacadePattern
{
    public class Customer
    {
        private int _id;
        private string _name;

        public Customer(int id, string name)
        {
            this._id = id;
            this._name = name;
        }

        public int Id
        {
            get { return _id; }
        }
        public string Name
        {
            get { return _name; }
        }

    }
}
