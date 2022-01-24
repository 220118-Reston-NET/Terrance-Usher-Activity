namespace ProjectZeroModel
{
    public class Inv
    {
        public int ItemNumber { get; set; }
        private int _itemQuantity;
        public int ItemQuantity
        {
            get { return _itemQuantity; }
            set 
            { 
                if (value >=  0)
                {
                    _itemQuantity = value;
                }
                else
                {
                    throw new Exception("Item Quantity can not be less than zero!");
                }
            }
        }
        
    }

}
