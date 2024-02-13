# Easy Mart Inventory Management System

Easy Mart Inventory Management System is a simple web application built using ASP.NET MVC for managing products and their inventory. 
The system allows users to add new products, check the inventory with the existing product list, and delete products.

## Project Structure

### Models

#### `Product`
- Represents a product with properties such as `ProductID`, `ProductName`, `Description`, and `Price`.

#### `Inventory`
- Represents inventory information for a product, including `InventoryID`, `StockQuantity`, `ProductID`, and a reference to the associated `Product` through `AccessProduct`.

#### `InventoryBusinessLogic`
- Contains business logic for managing inventory, including methods for adding inventory and retrieving the inventory list.

#### `ProductBusinessLogic`
- Contains business logic for managing products, including methods for adding products, retrieving the product list, and deleting products.

#### `TotalDetails`
- Represents a ViewModel containing both product and inventory information.

### Controllers

#### `StoreController`
- Manages the flow of the application, including actions for displaying the product list, adding new products, displaying inventory, and deleting products.

### Views

#### `Index.cshtml`
- Home page with links to add new products and check inventory.

#### `AddProduct.cshtml`
- View for adding new products, includes a form with fields for product name, description, price, and stock quantity.

#### `DisplayInventory.cshtml`
- View for displaying the product list along with associated inventory details. Provides an option to delete products.

## Usage

1. Visit the home page to navigate to different sections.
2. Click "Add New Product" to add a new product by entering details in the form.
3. Click "Check Inventory" to view the product list along with associated inventory details.
4. Use the "Delete" button in the inventory view to delete products.

## Acknowledgments
During the creation of this project, I found Stack Overflow to be incredibly helpful. Whenever I encountered challenges 
or needed to better understand certain programming concepts, I turned to Stack Overflow. The community there 
provided valuable guidance, allowing me to refine and clarify specific aspects of my code. 
