------ TABLES ------
--------------------

-- Create USER table
CREATE TABLE USERS (
    id NUMBER,
    email VARCHAR2(255) UNIQUE,
    username VARCHAR2(100),
    password VARCHAR2(255),
    role VARCHAR2(20) CHECK (role IN ('ADMIN', 'AUTHOR', 'READER')),
    PRIMARY KEY (id)
);

-- Create CATEGORY table
CREATE TABLE CATEGORIES (
    id NUMBER,
    name VARCHAR2(100),
    PRIMARY KEY (id)
);

-- Create MAGAZINE table
CREATE TABLE MAGAZINES (
    id NUMBER,
    name VARCHAR2(255),
    admin_id NUMBER,
    publication_date DATE,
    PRIMARY KEY (id),
    FOREIGN KEY (admin_id) REFERENCES USERS(id)
);


-- Create ARTICLE table
CREATE TABLE ARTICLES (
    id NUMBER,
    title VARCHAR2(255),
    magazine_id NUMBER,
    author_id NUMBER,
    category_id NUMBER,
    content VARCHAR2(2000),
    status VARCHAR2(20) CHECK (status IN ('PENDING', 'APPROVED', 'REJECTED')),
    PRIMARY KEY (id),
    FOREIGN KEY (magazine_id) REFERENCES MAGAZINES(id),
    FOREIGN KEY (author_id) REFERENCES USERS(id),
    FOREIGN KEY (category_id) REFERENCES CATEGORIES(id)
);



-- Create MAGAZINE_ARTICLES table
CREATE TABLE MAGAZINE_ARTICLES (
    magazine_id NUMBER,
    article_id NUMBER,
    PRIMARY KEY (magazine_id, article_id),
    FOREIGN KEY (magazine_id) REFERENCES MAGAZINES(id),
    FOREIGN KEY (article_id) REFERENCES ARTICLES(id)
);

-- Create SUBSCRIPTION table
CREATE TABLE SUBSCRIPTIONS (
    reader_id NUMBER,
    magazine_id NUMBER,
    start_date DATE,
    end_date DATE,
    price NUMBER,
    PRIMARY KEY (reader_id, magazine_id),
    FOREIGN KEY (reader_id) REFERENCES USERS(id),
    FOREIGN KEY (magazine_id) REFERENCES MAGAZINES(id)
);

--------- SEQUENCES ----------
------------------------------
-- Create sequences
CREATE SEQUENCE user_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE category_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE article_seq START WITH 1 INCREMENT BY 1;
CREATE SEQUENCE magazine_seq START WITH 1 INCREMENT BY 1;


-------- TRIGGERS --------

-- Trigger for USERS table
CREATE OR REPLACE TRIGGER user_trigger
BEFORE INSERT ON USERS
FOR EACH ROW
BEGIN
    SELECT user_seq.nextval INTO :new.id FROM dual;
END;
/

-- Trigger for CATEGORY table
CREATE OR REPLACE TRIGGER category_trigger
BEFORE INSERT ON CATEGORIES
FOR EACH ROW
BEGIN
    SELECT category_seq.nextval INTO :new.id FROM dual;
END;
/

-- Trigger for ARTICLE table
CREATE OR REPLACE TRIGGER article_trigger
BEFORE INSERT ON ARTICLES
FOR EACH ROW
BEGIN
    SELECT article_seq.nextval INTO :new.id FROM dual;
END;
/

-- Trigger for MAGAZINE table
CREATE OR REPLACE TRIGGER magazine_trigger
BEFORE INSERT ON MAGAZINES
FOR EACH ROW
BEGIN
    SELECT magazine_seq.nextval INTO :new.id FROM dual;
END;
/

-----------------------------
------- MAGAZINE SHIT -------
-----------------------------

-- Create procedure for inserting a new magazine
CREATE OR REPLACE PROCEDURE insert_magazine(
    name_in IN VARCHAR2,
    admin_id_in IN NUMBER,
    publication_date_in IN DATE
) AS
BEGIN
    INSERT INTO MAGAZINES (name, admin_id, publication_date)
    VALUES (name_in, admin_id_in, publication_date_in);
    COMMIT;
END insert_magazine;
/

-- Create procedure for updating magazine information
CREATE OR REPLACE PROCEDURE update_magazine(
    id_in IN NUMBER,
    name_in IN VARCHAR2,
    admin_id_in IN NUMBER
) AS
BEGIN
    UPDATE MAGAZINES
    SET name = name_in,
        admin_id = admin_id_in
    WHERE id = id_in;
    COMMIT;
END update_magazine;
/

-- Create procedure for deleting a magazine
CREATE OR REPLACE PROCEDURE delete_magazine(
    id_in IN NUMBER
) AS
BEGIN
    DELETE FROM MAGAZINES
    WHERE id = id_in;
    COMMIT;
END delete_magazine;
/

-- Create procedure for retrieving magazine information
CREATE OR REPLACE PROCEDURE get_magazine(
    id_in IN NUMBER,
    magazine_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN magazine_out FOR
    SELECT * FROM MAGAZINES
    WHERE id = id_in;
END get_magazine;
/


--------------------------------
--------- ARTICLE SHIT ---------
--------------------------------

CREATE OR REPLACE PROCEDURE insert_article(
    title_in IN VARCHAR2,
    magazine_id_in IN NUMBER,
    author_id_in IN NUMBER,
    category_id_in IN NUMBER,
    content_in IN VARCHAR2
) AS
    v_article_id NUMBER;
BEGIN
    INSERT INTO ARTICLES (id, title, magazine_id, author_id, category_id, content, status)
    VALUES (article_seq.nextval, title_in, magazine_id_in, author_id_in, category_id_in, content_in, 'PENDING')
    RETURNING id INTO v_article_id;
    
    INSERT INTO MAGAZINE_ARTICLES (magazine_id, article_id)
    VALUES (magazine_id_in, v_article_id);
    
    COMMIT;
END insert_article;
/

-- Create procedure for updating article information
CREATE OR REPLACE PROCEDURE update_article(
    id_in IN NUMBER,
    title_in IN VARCHAR2,
    category_id_in IN NUMBER,
    content_in IN VARCHAR2,
    status_in IN VARCHAR2
) AS
BEGIN
    UPDATE ARTICLES
    SET title = title_in,
        category_id = category_id_in,
        content = content_in,
        status = status_in
    WHERE id = id_in;
    COMMIT;
END update_article;
/

-- Create procedure for deleting an article
CREATE OR REPLACE PROCEDURE delete_article(
    id_in IN NUMBER
) AS
BEGIN
    DELETE FROM ARTICLES
    WHERE id = id_in;
    COMMIT;
END delete_article;
/

-- Create procedure for retrieving article information
CREATE OR REPLACE PROCEDURE get_article(
    id_in IN NUMBER,
    article_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN article_out FOR
    SELECT * FROM ARTICLES
    WHERE id = id_in;
END get_article;
/

-- Create procedure for updating the status of a pending article
CREATE OR REPLACE PROCEDURE update_pending_article_status(
    id_in IN NUMBER,
    status_in IN VARCHAR2
) AS
BEGIN
    UPDATE ARTICLES
    SET status = status_in
    WHERE id = id_in AND status = 'PENDING';
    COMMIT;
END update_pending_article_status;
/

CREATE OR REPLACE PROCEDURE get_articles_by_magazine(
    magazine_id_in IN NUMBER,
    articles_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN articles_out FOR
    SELECT * FROM ARTICLES
    WHERE magazine_id = magazine_id_in;
END get_articles_by_magazine;
/


----------------------------------
--------- CATEGORY SHIT ----------
----------------------------------


-- Create procedure for inserting a new category
CREATE OR REPLACE PROCEDURE insert_category(
    name_in IN VARCHAR2
) AS
BEGIN
    INSERT INTO CATEGORIES (id, name)
    VALUES (category_seq.nextval, name_in);
    COMMIT;
END insert_category;
/

-- Create procedure for updating category information
CREATE OR REPLACE PROCEDURE update_category(
    id_in IN NUMBER,
    name_in IN VARCHAR2
) AS
BEGIN
    UPDATE CATEGORIES
    SET name = name_in
    WHERE id = id_in;
    COMMIT;
END update_category;
/

-- Create procedure for deleting a category
CREATE OR REPLACE PROCEDURE delete_category(
    id_in IN NUMBER
) AS
BEGIN
    DELETE FROM CATEGORIES
    WHERE id = id_in;
    COMMIT;
END delete_category;
/

-- Create procedure for retrieving category information
CREATE OR REPLACE PROCEDURE get_category(
    id_in IN NUMBER,
    category_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN category_out FOR
    SELECT * FROM CATEGORIES
    WHERE id = id_in;
END get_category;
/


----------------------------------
------- SUBSCRIPTION SHIT --------
----------------------------------

-- Create procedure for inserting a new subscription
CREATE OR REPLACE PROCEDURE insert_subscription(
    reader_id_in IN NUMBER,
    magazine_id_in IN NUMBER,
    start_date_in IN DATE,
    end_date_in IN DATE,
    price_in IN NUMBER
) AS
BEGIN
    INSERT INTO SUBSCRIPTIONS (reader_id, magazine_id, start_date, end_date, price)
    VALUES (reader_id_in, magazine_id_in, start_date_in, end_date_in, price_in);
    COMMIT;
END insert_subscription;
/

-- Create procedure for updating subscription information
CREATE OR REPLACE PROCEDURE update_subscription(
    reader_id_in IN NUMBER,
    magazine_id_in IN NUMBER,
    start_date_in IN DATE,
    end_date_in IN DATE,
    price_in IN NUMBER
) AS
BEGIN
    UPDATE SUBSCRIPTIONS
    SET start_date = start_date_in,
        end_date = end_date_in, 
        price = price_in
    WHERE reader_id = reader_id_in AND magazine_id = magazine_id_in;
    COMMIT;
END update_subscription;
/

-- Create procedure for deleting a subscription
CREATE OR REPLACE PROCEDURE delete_subscription(
    reader_id_in IN NUMBER,
    magazine_id_in IN NUMBER
) AS
BEGIN
    DELETE FROM SUBSCRIPTIONS
    WHERE reader_id = reader_id_in AND magazine_id = magazine_id_in;
    COMMIT;
END delete_subscription;
/

-- Create procedure for retrieving subscription information
CREATE OR REPLACE PROCEDURE get_subscription(
    reader_id_in IN NUMBER,
    magazine_id_in IN NUMBER,
    subscription_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN subscription_out FOR
    SELECT * FROM SUBSCRIPTIONS
    WHERE reader_id = reader_id_in AND magazine_id = magazine_id_in;
END get_subscription;
/



-------------------------------
---------- USER SHIT ----------
-------------------------------

-- Create procedure for inserting a new user
CREATE OR REPLACE PROCEDURE insert_user(
    email_in IN VARCHAR2,
    username_in IN VARCHAR2,
    password_in IN VARCHAR2,
    role_in IN VARCHAR2
) AS
BEGIN
    INSERT INTO USERS (email, username, password, role)
    VALUES (email_in, username_in, password_in, role_in);
    COMMIT;
END insert_user;
/

-- Create procedure for updating user information
CREATE OR REPLACE PROCEDURE update_user(
    id_in IN NUMBER,
    email_in IN VARCHAR2,
    username_in IN VARCHAR2,
    password_in IN VARCHAR2,
    role_in IN VARCHAR2
) AS
BEGIN
    UPDATE USERS
    SET email = email_in,
        username = username_in,
        password = password_in,
        role = role_in
    WHERE id = id_in;
    COMMIT;
END update_user;
/

-- Create procedure for deleting a user
CREATE OR REPLACE PROCEDURE delete_user(
    id_in IN NUMBER
) AS
BEGIN
    DELETE FROM USERS
    WHERE id = id_in;
    COMMIT;
END delete_user;
/

-- Create procedure for retrieving user information
CREATE OR REPLACE PROCEDURE get_user(
    id_in IN NUMBER,
    user_out OUT SYS_REFCURSOR
) AS
BEGIN
    OPEN user_out FOR
    SELECT * FROM USERS
    WHERE id = id_in;
END get_user;
/


--------------------------
----- INSERTING SHIT -----
--------------------------

-- Inserting users
INSERT INTO "USERS" (email, username, password, role)
VALUES ('admin@example.com', 'admin_user', 'adminpass', 'ADMIN');

INSERT INTO "USERS" (email, username, password, role)
VALUES ('author1@example.com', 'author_one', 'authorpass', 'AUTHOR');

INSERT INTO "USERS" (email, username, password, role)
VALUES ('reader1@example.com', 'reader_one', 'readerpass', 'READER');

INSERT INTO USERS (email, username, password, role)
VALUES ('author2@example.com', 'author_two', 'authorpass', 'AUTHOR');

INSERT INTO USERS (email, username, password, role)
VALUES ('reader2@example.com', 'reader_two', 'readerpass', 'READER');



-- Inserting categories
INSERT INTO CATEGORIES (name)
VALUES ('Technology');

INSERT INTO CATEGORIES (name)
VALUES ('Science');

INSERT INTO CATEGORIES (name)
VALUES ('Fashion');

INSERT INTO CATEGORIES (name)
VALUES ('Health');

INSERT INTO CATEGORIES (name)
VALUES ('Travel');


-- Inserting articles
DECLARE
    v_title VARCHAR2(255) := 'New Trends in Technology';
    v_magazine_id NUMBER := 1; -- Assuming the magazine ID where the article belongs
    v_author_id NUMBER := 2;   -- Assuming the author ID who wrote the article
    v_category_id NUMBER := 1; -- Assuming the category ID of the article
    v_content VARCHAR2(4000) := 'This article explores emerging trends in technology.';
BEGIN
    insert_article(v_title, v_magazine_id, v_author_id, v_category_id, v_content);
    DBMS_OUTPUT.PUT_LINE('Article inserted successfully.');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error inserting article: ' || SQLERRM);
END;
/

DECLARE
    v_title VARCHAR2(255) := 'Space Exploration: The Next Frontier';
    v_magazine_id NUMBER := 2; -- Assuming the magazine ID where the article belongs
    v_author_id NUMBER := 2;   -- Assuming the author ID who wrote the article
    v_category_id NUMBER := 2; -- Assuming the category ID of the article
    v_content VARCHAR2(4000) := 'This article delves into the future of space exploration.';
BEGIN
    insert_article(v_title, v_magazine_id, v_author_id, v_category_id, v_content);
    DBMS_OUTPUT.PUT_LINE('Article inserted successfully.');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error inserting article: ' || SQLERRM);
END;
/

DECLARE
    v_title VARCHAR2(255) := 'Healthy Eating Habits';
    v_magazine_id NUMBER := 1; -- Assuming the magazine ID where the article belongs
    v_author_id NUMBER := 7;   -- Assuming the author ID who wrote the article
    v_category_id NUMBER := 4; -- Assuming the category ID of the article
    v_content VARCHAR2(4000) := 'This article discusses the importance of healthy eating.';
BEGIN
    insert_article(v_title, v_magazine_id, v_author_id, v_category_id, v_content);
    DBMS_OUTPUT.PUT_LINE('Article inserted successfully.');
EXCEPTION
    WHEN OTHERS THEN
        DBMS_OUTPUT.PUT_LINE('Error inserting article: ' || SQLERRM);
END;
/


-- Inserting magazines
INSERT INTO MAGAZINES (name, admin_id, publication_date)
VALUES ('Tech Insider', 1, TO_DATE('2024-04-01', 'YYYY-MM-DD'));

INSERT INTO MAGAZINES (name, admin_id, publication_date)
VALUES ('Science Today', 1, TO_DATE('2024-05-01', 'YYYY-MM-DD'));

INSERT INTO MAGAZINES (name, admin_id, publication_date)
VALUES ('Health and Wellness', 1, TO_DATE('2024-04-15', 'YYYY-MM-DD'));

INSERT INTO MAGAZINES (name, admin_id, publication_date)
VALUES ('Travel Journal', 1, TO_DATE('2024-05-10', 'YYYY-MM-DD'));


-- Linking articles to magazines
INSERT INTO MAGAZINE_ARTICLES (magazine_id, article_id)
VALUES (1, 1);

INSERT INTO MAGAZINE_ARTICLES (magazine_id, article_id)
VALUES (1, 2);

INSERT INTO MAGAZINE_ARTICLES (magazine_id, article_id)
VALUES (4, 3);


-- Inserting subscriptions
INSERT INTO SUBSCRIPTIONS (reader_id, magazine_id, start_date, end_date)
VALUES (3, 1, TO_DATE('2024-05-01', 'YYYY-MM-DD'), TO_DATE('2024-12-31', 'YYYY-MM-DD'));


INSERT INTO SUBSCRIPTIONS (reader_id, magazine_id, start_date, end_date)
VALUES (8, 1, TO_DATE('2024-05-01', 'YYYY-MM-DD'), TO_DATE('2024-12-31', 'YYYY-MM-DD'));

INSERT INTO SUBSCRIPTIONS (reader_id, magazine_id, start_date, end_date)
VALUES (6, 2, TO_DATE('2024-05-01', 'YYYY-MM-DD'), TO_DATE('2024-12-31', 'YYYY-MM-DD'));


