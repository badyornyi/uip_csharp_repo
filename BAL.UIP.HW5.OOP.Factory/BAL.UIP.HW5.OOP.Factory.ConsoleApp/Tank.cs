namespace BAL.UIP.HW5.OOP.Factory.ConsoleApp
{
    public class Tank
    {
        public string TankName { get; set; }
        public bool IsReady { get; set; }
        private int RequiredWorkCapacity { get; }
        public int ReadyWorkCapacity { get; set; }

        public void ChangeReadyWorkCapacity()
        {
            return;
        }
    }
}