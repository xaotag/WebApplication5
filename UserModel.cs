namespace WebApplication5
{
    public class UserModel
    {
        private string Guid;
        private string mobile;
        private string pwd;


        public string Guid1
        {
            get => Guid;
            set => Guid = value;
        }

        public string Mobile
        {
            get => mobile;
            set => mobile = value;
        }

        public string Pwd
        {
            get => pwd;
            set => pwd = value;
        }
    }
}