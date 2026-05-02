# 🧋 MilkTea POS System

A Point of Sale (POS) desktop application built with **Visual Basic .NET** and **MySQL**, designed for milk tea shop operations. Features a role-based login system, real-time cart management, inventory tracking, thermal receipt printing, and transaction logs.

---

## ✨ Features

### 🔐 Authentication
- User login and sign-up system
- **Role-based access control:**
  - **Admin (Role 1):** Full access — POS, product management, inventory, transaction logs, analytics
  - **Cashier (Role 2):** Limited access — POS, transaction logs, analytics only

### 🛒 Point of Sale (Buy Form)
- Browse products with a searchable data grid
- Add items to cart with customizable options:
  - **Size** (Large / Small)
  - **Sugar Level**
  - **Add-ons**
- Edit or delete individual cart items
- Real-time cart total and quantity calculation
- Confirm order with payment amount input and change calculation
- Auto-decrement product stock on confirmed orders
- **Thermal receipt printing** via `PrintDocument` (formatted receipt layout)
- Cart clears automatically on app close or cancel

### 📦 Product & Inventory Management
- Add, edit, and delete products (name, size pricing, stock)
- Manage add-ons / variants separately
- Stock levels update automatically with each confirmed sale
- Inventory Management dashboard for stock monitoring

### 📋 Transaction Logs
- Full order history with receipt IDs, item details, quantities, and totals
- Recent transactions view

### 📊 Analytics Dashboard
- View recent sales and order activity

---

## 🛠️ Tech Stack

| Layer       | Technology                        |
|-------------|-----------------------------------|
| Language    | Visual Basic .NET (VB.NET)        |
| Framework   | .NET Framework 4.7.2              |
| UI          | Windows Forms (WinForms)          |
| Database    | MySQL 8.x                         |
| ORM/Driver  | MySql.Data (MySql.Data.MySqlClient)|
| Icons       | FontAwesome.Sharp, Icons8.UI      |
| IDE         | Visual Studio 2022                |

---

## 🗄️ Database Setup

1. Install **MySQL** and create a database named `milktea`:
   ```sql
   CREATE DATABASE milktea;
   ```

2. Create the required tables:
   ```sql
   USE milktea;

   CREATE TABLE products (
     productID INT AUTO_INCREMENT PRIMARY KEY,
     Variant VARCHAR(100),
     largePrice DECIMAL(10,2),
     SmallPrice DECIMAL(10,2),
     stocks INT DEFAULT 0
   );

   CREATE TABLE cart (
     OrderID INT AUTO_INCREMENT PRIMARY KEY,
     Variant VARCHAR(100),
     Size VARCHAR(20),
     SugarLevel VARCHAR(20),
     Price DECIMAL(10,2),
     Quantity INT,
     Addon DECIMAL(10,2),
     AddonName VARCHAR(100),
     Total DECIMAL(10,2)
   );

   CREATE TABLE orders (
     orderID INT AUTO_INCREMENT PRIMARY KEY,
     receiptID INT,
     Variant VARCHAR(100),
     Size VARCHAR(20),
     Price DECIMAL(10,2),
     Addon DECIMAL(10,2),
     AddonName VARCHAR(100),
     Quantity INT,
     Total DECIMAL(10,2),
     Date DATETIME
   );

   CREATE TABLE receipt (
     receiptID INT AUTO_INCREMENT PRIMARY KEY,
     totalAmount DECIMAL(10,2),
     date DATETIME
   );

   CREATE TABLE users (
     userID INT AUTO_INCREMENT PRIMARY KEY,
     username VARCHAR(100),
     password VARCHAR(100),
     role INT
   );
   ```

3. Update the connection string in `SQL.vb` if needed:
   ```vb
   Return New MySqlConnection("server=localhost;user id=root;password=YOUR_PASSWORD;database=milktea")
   ```

---

## 🚀 Getting Started

### Prerequisites
- Windows OS
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (Community edition works)
- [MySQL Server](https://dev.mysql.com/downloads/mysql/) (v8.x recommended)
- .NET Framework 4.7.2

### Steps
1. Clone this repository:
   ```bash
   git clone https://github.com/YOUR_USERNAME/MilkTeaPOS.git
   ```
2. Open `MilkTeaPOS.sln` in Visual Studio
3. Set up the MySQL database (see [Database Setup](#-database-setup))
4. Restore NuGet packages (Visual Studio should do this automatically)
5. Build and run (`F5`)

---

## 📁 Project Structure

```
MilkTeaPOS/
├── LOGIN FORM/
│   ├── LoginForm.vb          # User login
│   └── SignUpForm.vb         # User registration
├── Dashboard/
│   ├── BuyForm.vb            # Main POS / cart interface
│   ├── ProductInventory.vb   # Product listing & edit
│   ├── InventoryManagement.vb# Stock management
│   ├── TransactionLogs.vb    # Order history
│   └── RecentForm.vb         # Analytics / recent sales
├── SubDashboard/
│   ├── AddProductForm.vb     # Add item to cart
│   ├── EditProductForm.vb    # Edit cart item
│   └── AmountReceived.vb     # Payment / change calculator
├── IM_Dashboard/
│   ├── ProductStock.vb       # Product stock view
│   └── AddOnsStock.vb        # Add-ons stock view
├── PI_SubDashboard/
│   ├── EditProductInformation.vb
│   └── EditAddOnsInformation.vb
├── CreateProduct.vb          # Create new product
├── CreateAddons.vb           # Create new add-on
├── MainForm.vb               # Main dashboard shell
├── SQL.vb                    # Database helper module
└── MilkTeaPOS.vbproj
```

---

## 📸 Screenshots

> _Screenshots coming soon

---

## 👤 Author

**John Vincent T. Canciller**
- GitHub: [@YOUR_USERNAME](https://github.com/YOUR_USERNAME]https://github.com/meowzea)
- LinkedIn: [john-vincent-canciller](https://linkedin.com/in/john-vincent-canciller)
- Email: jvcanciller@gmail.com

---

## 📄 License

This project is for portfolio and educational purposes.
