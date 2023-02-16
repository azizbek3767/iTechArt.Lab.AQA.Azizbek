using SeleniumWrapper.Page.Tests;

namespace SeleniumWrapper.Tests.Tests
{
    internal class ProductsPageTests : BaseTest
    {
        [Test]
        public void JustTest()
        {
            //1.Перейти на сайт Купить Телевизоры в интернет магазине MEDIAPARK.UZ в Ташкенте.
            ProductsPage.OpenPage();
            //Ожидаемый результат: Страница с сайтом открыта
            Assert.True(ProductsPage.IsPageOpened, "Products page should be opened");
            //2.Добавить в корзину два первых телевизора
            ProductsPage.AddTwoItemsToTheCard();

            //3.Нажать на иконку «корзина»
            ProductsPage.ClickCardButton();
            //Ожидаемый результат: корзина открыта, количество добавленных товаров 2 штуки
            Assert.True(ProductsPage.IsCardSidebarOpened, "Card sidebar should be opened");
            Assert.True(ProductsPage.IsCarditemsCountTrue, "Card items count should be true");

            //4.Нажать на кнопку «заказать»
            ProductsPage.ClickOrderButton();
            //Ожидаемый результат: страница «оформление заказа» открыта»
            Assert.True(CheckoutPage.IsPageOpened, "Checkout page should be opened");

            //5.Заполнить обязательные поля «Информация о покупателе»(любые данные)
            CheckoutPage.FillInCheckoutPageForm();
            Thread.Sleep(5000);
            //Ожидаемый результат: информация о покупателе на странице, соответствует той, что вы ввели ранее

            //6.Заполнить поля «информация о доставке»(любые данные)
            //Ожидаемый результат: информация о доставке на странице, соответствует той, что вы ввели ранее

            //7.В разделе «Платежная информация» выбрать «Наличные», ввести «Код с картинки», нажать чекбокс «Я согласен с условиями соглашения»

            //8.Нажать кнопку «оформить заказ»
            //Ожидаемый результат: на старнице есть надпись «Ваш заказ оформлен»


        }
    }
}
