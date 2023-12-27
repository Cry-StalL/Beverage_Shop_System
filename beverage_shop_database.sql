SET foreign_key_checks = 0;

DROP TABLE IF EXISTS drink_info;
CREATE TABLE drink_info
(
    drink_id INT PRIMARY KEY AUTO_INCREMENT,
    drink_name VARCHAR(255) NOT NULL, -- unique
    drink_image VARCHAR(255) NULL,
    price_small DOUBLE(10,2) NULL,
    price_medium DOUBLE(10,2) NULL,
    price_large DOUBLE(10,2) NULL,
    status int NOT NULL DEFAULT 1, -- 1在售, 2售完, 3停售，默认值为1
    
    UNIQUE (drink_name)
    
);

DROP TABLE IF EXISTS drink_price_info;
CREATE TABLE drink_price_info
(
    drink_price_id INT PRIMARY KEY AUTO_INCREMENT,
    drink_id INT, -- 外键
    price_small DOUBLE(10,2) NULL,
    price_medium DOUBLE(10,2) NULL,
    price_large DOUBLE(10,2) NULL,
    begin_date DATETIME,
    end_date DATETIME,
    FOREIGN KEY (drink_id) REFERENCES drink_info(drink_id)
);

DROP TABLE IF EXISTS user_info;
CREATE TABLE user_info
(
    user_id INT PRIMARY KEY AUTO_INCREMENT,
    real_name VARCHAR(255) NULL, -- 真实姓名
    gender INT NULL DEFAULT NULL, -- 0男，1女, NULL未知，默认值为NULL
    telephone INT NULL,
    delete_flag INT DEFAULT  0, -- 0正常，1已被删除

    -- staff_specific_field
    username VARCHAR(255) NULL, -- unique
    password VARCHAR(255) NULL,

    -- member_specific_field
    member_id INT NULL, -- 会员卡号
    
    -- usertype
    user_type INT NOT NULL, -- 0为会员，1为操作员
    
    UNIQUE (username)
);

DROP TABLE IF EXISTS order_info;
CREATE TABLE order_info(
   order_id INT PRIMARY KEY AUTO_INCREMENT,
   count INT NOT NUll, -- 饮品杯数

    -- 订单支付信息
   order_amount DOUBLE(10,2) NOT NULL, -- 订单总额
   amount_rate DOUBLE(10,2) NOT NULL, -- 金额比例
   discount_amount DOUBLE(10,2) NOT NULL,
   paid_amount DOUBLE(10,2) NOT NULL,
   pay_method INT NOT NULL, -- 1现金，2银行卡，3微信，4支付宝
   order_time DATETIME NOT NULL,

    -- 顾客-会员信息(若有)
   member_id INT NULL, -- 会员卡号(外键)

    -- 操作员
   staff_username VARCHAR(255) NOT NULL -- 用户名(外键)

-- 	FOREIGN KEY (member_id) REFERENCES user_info(member_id),
-- 	FOREIGN KEY (staff_username) REFERENCES user_info(username)
);

DROP TABLE IF EXISTS order_item_info;
CREATE TABLE order_item_info
(
    order_item_id INT PRIMARY KEY AUTO_INCREMENT,
    order_id INT NOT NUll, -- 外键
    drink_id INT NOT NULL, -- 外键
    size INT NOT NULL, -- 0小，1中，2大
    count INT NOT NULL -- 杯数
);

SET foreign_key_checks = 1;