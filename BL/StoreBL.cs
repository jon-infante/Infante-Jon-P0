namespace BL;

public class StoreBL {
    private StoreRepo _dl;

    public StoreBL() {
        _dl = new StoreRepo();
    }
    /// <summary>
    /// Gets all stores
    /// </summary>
    /// <returns>list of all stores</returns>
    public List<Store> GetAllStores(){
        return _dl.GetAllStores();
    }
    /// <summary>
    /// Get current store by the store's ID
    /// </summary>
    /// <param name="storeID">storeID to look up</param>
    /// <returns>Store object</returns>
    public Store GetStoreByID(int storeID){
        return _dl.GetStoreByID(storeID);
        }
    /// <summary>
    /// Get current store's index by storeID
    /// </summary>
    /// <param name="storeID">storeID to look up</param>
    /// <returns>store index</returns>
    public int GetStoreIndexByID(int storeID){
        return _dl.GetStoreIndexByID(storeID);
        }
    /// <summary>
    /// Adds a new store to the list
    /// </summary>
    /// <param name="storeToAdd">store object to add</param>
    
    public Product GetProductByID(int storeID, int prodID){
        return _dl.GetProductByID(storeID, prodID);
    }
    public void AddStore(Store storeToAdd){
        _dl.AddStore(storeToAdd);
    }
    /// <summary>
    /// Adds a product to the current selected store
    /// </summary>
    /// <param name="storeID">ID of the current store</param>
    /// <param name="productToAdd">product we are adding to the store</param>
    public void AddProduct(int storeID, Product productToAdd){
        _dl.AddProduct(storeID, productToAdd);
    }
    /// <summary>
    /// Deletes a product from the current selected store and product index
    /// </summary>
    /// <param name="storeID">ID of the current store</param>
    /// <param name="prodIndex">Product's current index</param>
    public void DeleteProduct(int storeID, int prodIndex){
        _dl.DeleteProduct(storeID, prodIndex);

    }
    /// <summary>
    /// Edits and updates the product selected in the current store
    /// </summary>
    /// <param name="storeID">ID of the current store</param>
    /// <param name="prodID">ID of the current product</param>
    /// <param name="description">Product's new description</param>
    /// <param name="price">Product's new price</param>
    /// <param name="quantity">Product's new quantity</param>
    public void EditProduct(int storeIndex, int prodIndex, string description, string price, string quantity){
        _dl.EditProduct(storeIndex, prodIndex, description, price, quantity);
    }
    /// <summary>
    /// Takes the current lists of product orders, packages them in a store order and adds to list
    /// </summary>
    /// <param name="storeID">ID of the current store</param>
    /// <param name="storeOrderToAdd">Store order packaged and ready to add</param>
    public void AddStoreOrder(int storeID, StoreOrder storeOrderToAdd){
        _dl.AddStoreOrder(storeID, storeOrderToAdd);
    }

}
