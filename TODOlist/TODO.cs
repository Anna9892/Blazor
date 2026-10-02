namespace TODOlist
{
    public class TODO
    {
        public string Description { get; set; }

        public bool DONE { get; set; }

        public System.DateTime CreatedAt { get; set; } = System.DateTime.Now;

        public override bool Equals(object? other)
        {
           return this.Description.Equals((other as TODO).Description);
        }
    }
}
