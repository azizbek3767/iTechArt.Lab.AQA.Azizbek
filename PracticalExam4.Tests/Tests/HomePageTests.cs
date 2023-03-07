namespace PracticalExam4.Tests.Tests
{
    internal class HomePageTests : BaseTest
    {
        [Test]
        public void Select_Dates_Check_Demo()
        {
            HomePage.OpenPage();
            Assert.True(HomePage.IsPageOpened, "Home page should be opened");
            HomePage.ClickTestTaskButton();

            HomePage.ClearSelectedDatas();

            HomePage.PickDate(-365);
            HomePage.PickDate(0);
            HomePage.PickDate(700);
            HomePage.PickDate(600);
            HomePage.PickDate(-666);
            HomePage.PickDate(66);
            HomePage.PickDate(-366);
            HomePage.PickDate(-363);
            HomePage.PickDate(-333);
            HomePage.PickDate(4);
            HomePage.PickDate(1000000);

            Thread.Sleep(5000);
        }
    }
}
