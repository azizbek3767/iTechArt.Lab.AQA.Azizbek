# Singletom
In this project, the Singleton pattern is used in BrowserService class on 15 line
# example
private static IBrowser GetBrowser()
{
    if (!IsApplicationStarted())
    {
        BrowserContainer.Value = BrowserFactory.GetBrowser;
    }

    return BrowserContainer.Value;
}
Here, I create the new instance of WebDriver class only when it's the first time. And, in every next call
the allready created instance is returned.




# Builder
In this project, the Builder pattern is used commonly. In Saucedemo.Core project, I've added Builders 
folder and inside this folder added different kinds of builders. Those builders are used in the log in part.
I've created different kinds of builders for every type of user for saucedemo app. Furthermore, inside Models
folder, I've defined User class. The abovementioned builders interact with this model when filling the log
in form.
# example
public void LoginAsA(string userType)
{
    var director = new UserBuilderDirector();
    var userBuilder = UserBuilderTypeSelector.SelectUserBuilderByString(userType);
    director.UserBuilder = userBuilder;
    director.BuildUser();
    var user = userBuilder.GetUser();
    UsernameInput.SendKeys(user.Username);
    PasswordInput.SendKeys(user.Password);
    LoginButton.Click();
}
this code is from LoginPage.cs and depending on the input returns different kinds of user types.




# Page Element
In this project, I used the Page Element pattern for the left sidebar. I created a folder called components.
And, inside this folder, I defined the a class for the left sidebar. defined all the four buttons and 
added methods to interact with those buttons. Then, I created a separate test class called LeftSidebarTests.cs
and inside this class checked all the four buttons of the sidebar for correctly functioning.
# example
private Button AllItemsButton => new Button(By.XPath("//a[@id=\"inventory_sidebar_link\"]"), "All items button");
public void ClickAllItemsButton()
{
    AllItemsButton.Click();
}
InventoryPage.LeftSidebarComponent.ClickAllItemsButton();

# Value Object
In this project, I used this pattern to fill the Checkout form for user data. I created CheckoutUserRequestModel and 
CheckoutUserRequestModelFactory. So I can hide the real implmentation.

# Steps (Actor)
In this project, I used this pattern to make a checkout operation. I have created a Steps folder and CheckoutStepOnePageSteps class.
And, created a separate test class called CheckoutTests_Via_Steps_Pattern and chained my tests in that class.

