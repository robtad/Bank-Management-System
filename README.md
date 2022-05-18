# BankMS
BankManagementSystemProject
This is a Bank Management System Project(App).
Built by Robera Tadesse Gobosho(me)(robtad318@gmail.com) and Muhammad Abdan Syakura(prof.syakur@gmail.com).
We are a second year Computer Engineerig Students(2022) at KOCAELI UNIVERSITY, TURKEY.

-The project is a WinForms App:
- framework: dotnet(.NET) framework.
- Front-end coding language: C#
- Back-end MS SQL(T-SQL)

The system has three roles:
1. Bank Manager
2. Teller (Customer Representative)
3. Bank Customers.

How does the app work ?:

1. manager,teller and customer can log in through a login form using their respective login username(ID) and password.
Bank Manager can:
    1. add,remove, and edit tellers and customers
    2. pay salary of teller's and change the amount
    3. fix the interest rate and overdue interest rate of the bank
    4. add,remove and edit other currencies and their exchange rate
    5. view teller's and customer's info and edit it
    6. view the bank's income,expenditures and profits
    7. add and edit bank date
    8. advance the bank's date-time by one month at once.(Our system uses it's own imaginary time(calender)) to check the functionality of the app such as salary payment and loan paymets etc.
    9. view the bank's transaction history.
2. Teller can:
    1. add,remove, and edit customers
    2. view their own customers' info and edit it.(every customer has his/her own teller(representative)
    3. approve or decline new account opening requests from his customers
    4. approve or decline loan request from his customers
    5. approve account deletion requests from his customers(account with non zero balance cannot be deleted)
    6. view their customers' transaction history
    7. view their customers' account balance and loans
    
3. Cutomer can:
    1. deposit and withdraw money to and from their account
    2. request for the opening of new account and deletions of their existing account(s)
    2. open more than one account: (eg dollar account, euro account etc)(there is no limit in the number of accounts customer can have)
    3. transfer money to other customers. (to other accounts of the same currency or different currency)(eg. from dollar acc to dollar acc or dollar acc to euro acc etc)
    4. view and update their personal info(name,email,phone,address etc)
    5. transfer money to the bank (i.e, loan payment)
    6. request loan from bank
    7. choose payment plan for their loan (i.e, expiration: 6 months, 12 months, 18 months etc)
    8. view monthly mortgage, principal,remaining principal and interest for each month for their loan.
    9. can payoff their monthly mortgage early, ontime, or late. 
                  Early payment: paid with no interest added
                  On time payment: paid with interest added
                  Late payment: paid with interest and overdue interest added
    10. view their transaction history.
    
Database:
     - All the tables are normalized to 3NF (Third Normal Form)
     - There are total of 26-tables
     - Query language: T-SQL.
     
The up to date source codes and files are in this repo.  

             
