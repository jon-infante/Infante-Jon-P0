using Xunit;
using Models;
using CustomExceptions;
using System.Collections.Generic;

namespace Tests;

public class ModelsTest{
    [Fact]
    public void UserShouldCreate(){
        //Arrange
        //To test this case I make sure im using the models namespace
        
        //Act: Create user object
        User testUser = new User();

        //Assert: Assert that the user was created
        Assert.NotNull(testUser);
    }

    [Fact]
    public void UserShouldSetValue(){
        //Arrange
        User testUser = new User();
        int ID = 42;
        string username = "Jon";
        string password = "banana";
        List<ProductOrder> shoppingCart = new List<ProductOrder>();
        List<StoreOrder> finishedOrders = new List<StoreOrder>();

        //Act
        testUser.ID = ID;
        testUser.Username = username;
        testUser.Password = password;
        testUser.ShoppingCart = shoppingCart;
        testUser.FinishedOrders = finishedOrders;

        //Assert
        Assert.Equal(ID, testUser.ID);
        Assert.Equal(username, testUser.Username);
        Assert.Equal(password, testUser.Password);
        Assert.Equal(shoppingCart, testUser.ShoppingCart);
        Assert.Equal(finishedOrders, testUser.FinishedOrders);

    }

    [Fact]
    public void ProductShouldCreateAndSetValues(){
        //Arrange
        Product testProduct = new Product();
        int ID = 99;
        int storeID = 9994;
        string name = "Iphone 12";
        string description = "Brand new";
        //Strings are used for price and quantity due to previous implementation of a method comparing if 
        //the value of the property was an empty string when entered by the user.
        string price = "99";
        string quantity = "4";

        //Act
        testProduct.ID = ID;
        testProduct.storeID = storeID;
        testProduct.Name = name;
        testProduct.Description = description;
        testProduct.Price = price;
        testProduct.Quantity = quantity;

        //Assert
        Assert.Equal(ID, testProduct.ID);
        Assert.Equal(storeID, testProduct.storeID);
        Assert.Equal(name, testProduct.Name);
        Assert.Equal(description, testProduct.Description);
        Assert.Equal(price, testProduct.Price);
        Assert.Equal(quantity, testProduct.Quantity);
    }

    [Theory]
    [InlineData("v", "6.4")]
    [InlineData("banana", "ty")]
    [InlineData("you", "5.3")]
    [InlineData("undefined", "4.1")]
    [InlineData("t", "66.66")]
    public void ProductShouldNotHaveInvalidQuantityorPrice(string price, string quantity){
        //Arrange: Testing if the product will have an invalid price or quantity. 
        //Price should be a decimal
        //Quantity should be an integer
        Product testProduct = new Product();

        //Act: Using inline data as paramaters

        //Assert
        Assert.Throws<InputInvalidException>(() => testProduct.Price = price);
        Assert.Throws<InputInvalidException>(() => testProduct.Quantity = quantity);
    }

    [Fact]
    public void StoreShouldCreate(){
        //Arrange
        //To test this case I make sure im using the models namespace
        
        //Act: Create store object
        Store testStore = new Store();

        //Assert: Assert that the store was created
        Assert.NotNull(testStore);
    }

    [Fact]
    public void StoreShouldSetValue(){
        //Arrange
        Store testStore = new Store();
        int ID = 5605045;
        string name = "Atlantic Branch";
        string address = "500 Seven Farms Dr";
        string city = "Charleston";
        string state = "SC";
        List<Product> products = new List<Product>();
        List<StoreOrder> allOrders = new List<StoreOrder>();

        //Act
        testStore.ID = ID;
        testStore.Name = name;
        testStore.Address = address;
        testStore.City = city;
        testStore.State = state;
        testStore.Products = products;
        testStore.AllOrders = allOrders;

        //Assert
        Assert.Equal(ID, testStore.ID);
        Assert.Equal(name, testStore.Name);
        Assert.Equal(address, testStore.Address);
        Assert.Equal(city, testStore.City);
        Assert.Equal(state, testStore.State);
        Assert.Equal(products, testStore.Products);
        Assert.Equal(allOrders, testStore.AllOrders);
    }

    [Fact]
    public void ProductOrderShouldSetValue(){
        //Arrange
        ProductOrder testPOrder = new ProductOrder();
        int ID = 4242;
        int userID = 99333;
        int storeID = 9994;
        int productID = 32332423;
        string itemName = "Pixel 4";
        //Strings are used for price and quantity due to previous implementation of a method comparing if 
        //the value of the property was an empty string when entered by the user.
        string TotalPrice = "999.99";
        string Quantity = "8";

        //Act
        testPOrder.ID = ID;
        testPOrder.userID = userID;
        testPOrder.storeID = storeID;
        testPOrder.productID = productID;
        testPOrder.ItemName = itemName;
        testPOrder.TotalPrice = TotalPrice;
        testPOrder.Quantity = Quantity;

        //Assert
        Assert.Equal(ID, testPOrder.ID);
        Assert.Equal(userID, testPOrder.userID);
        Assert.Equal(storeID, testPOrder.storeID);
        Assert.Equal(productID, testPOrder.productID);
        Assert.Equal(itemName, testPOrder.ItemName);
        Assert.Equal(TotalPrice, testPOrder.TotalPrice);
        Assert.Equal(Quantity, testPOrder.Quantity);   
    }

    [Theory]
    [InlineData("6.3")]
    [InlineData("pe")]
    [InlineData("99.2")]
    [InlineData("boxer")]
    [InlineData("5.2")]
    public void ProductOrderShouldNotHaveInvalidQuantity(string quantity){
        //Arrange: Testing if the product will have an invalid quantity. 
        //Quantity should be an integer
        ProductOrder testPOrder = new ProductOrder();

        //Act: Using inline data as paramaters

        //Assert
        Assert.Throws<InputInvalidException>(() => testPOrder.Quantity = quantity);
    }

    [Fact]
    public void StoreOrderShouldSetValue(){
        //Arrange
        StoreOrder testStoreOrder = new StoreOrder();
        int ID = 9032;
        int userID = 222935;
        string Date = "12/30/21 5:43PM";
        double DateSeconds = 999432.3377;
        decimal TotalAmount = 3829.98M;
        List<ProductOrder> Orders = new List<ProductOrder>();
        
        //Act
        testStoreOrder.ID = ID;
        testStoreOrder.userID = userID;
        testStoreOrder.Date = Date;
        testStoreOrder.DateSeconds = DateSeconds;
        testStoreOrder.TotalAmount = TotalAmount;
        testStoreOrder.Orders = Orders;

        //Assert
        Assert.Equal(ID, testStoreOrder.ID);
        Assert.Equal(userID, testStoreOrder.userID);
        Assert.Equal(Date, testStoreOrder.Date);
        Assert.Equal(DateSeconds, testStoreOrder.DateSeconds);
        Assert.Equal(TotalAmount, testStoreOrder.TotalAmount);
        Assert.Equal(Orders, testStoreOrder.Orders);
    }
}