namespace Google
{
    public class Childern
    {
        public string name;
        public string birthday;

        public Childern(string name, string birthday)
        {
            this.name = name;
            this.birthday = birthday;
        }
        public override string ToString()
        {
            return $"{this.name} {this.birthday}";
        }
    }
}
