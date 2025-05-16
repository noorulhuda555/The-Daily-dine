CREATE DATABASE daily_dine_db;
USE daily_dine_db;
CREATE TABLE users (
    id INT AUTO_INCREMENT PRIMARY KEY,
    username VARCHAR(50) NOT NULL UNIQUE,
    password VARCHAR(255) NOT NULL
);
-- Add role column to users table for cashiers (if not already present)
ALTER TABLE users ADD COLUMN role VARCHAR(20) DEFAULT 'user';

CREATE TABLE customers (
    id INT PRIMARY KEY AUTO_INCREMENT,
    username VARCHAR(255),
    email VARCHAR(255),
    password VARCHAR(255)
);


-- Orders table for income tracking
CREATE TABLE orders (
    id INT AUTO_INCREMENT PRIMARY KEY,
    amount DECIMAL(10, 2) NOT NULL,
    order_date TIMESTAMP DEFAULT CURRENT_TIMESTAMP
);
select * from users 
select * from orders 
select * from customers 

INSERT INTO customers (name) VALUES ('Customer1');
INSERT INTO customers (name) VALUES ('John Smith');
INSERT INTO customers (name) VALUES ('Emma Johnson');
INSERT INTO customers (name) VALUES ('Michael Brown');
INSERT INTO customers (name) VALUES ('Sophia Martinez');
INSERT INTO customers (name) VALUES ('David Wilson');
INSERT INTO customers (name) VALUES ('Olivia Anderson');
INSERT INTO customers (name) VALUES ('James Taylor');
INSERT INTO customers (name) VALUES ('Isabella Thomas');
INSERT INTO customers (name) VALUES ('William Harris');
INSERT INTO customers (name) VALUES ('Mia Robinson');

INSERT INTO orders (amount, order_date) VALUES (50.00, CURDATE());
INSERT INTO orders (amount) VALUES (100.00);


INSERT INTO orders (amount, order_date) VALUES (50.00, CURDATE());
INSERT INTO orders (amount, order_date) VALUES (100.00, CURDATE());
INSERT INTO orders (amount, order_date) VALUES (75.50, '2024-03-01');
INSERT INTO orders (amount, order_date) VALUES (200.25, '2024-03-02');
INSERT INTO orders (amount, order_date) VALUES (125.75, '2024-03-03');
INSERT INTO orders (amount, order_date) VALUES (300.00, '2024-03-04');
INSERT INTO orders (amount, order_date) VALUES (89.99, '2024-03-05');
INSERT INTO orders (amount, order_date) VALUES (150.60, '2024-03-06');
INSERT INTO orders (amount, order_date) VALUES (275.40, '2024-03-07');
INSERT INTO orders (amount, order_date) VALUES (50.99, '2024-03-08');
