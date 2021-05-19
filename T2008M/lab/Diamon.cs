namespace T2008M.lab
{
    public class Diamon : Product
    {
        public int cara;

        public bool CheckAuth()
        {
            if (cara > 10)
                return true;
            return false;
        }
    }
}