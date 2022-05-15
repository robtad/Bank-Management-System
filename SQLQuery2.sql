/*
SELECT DISTINCT PaymentDate, TotalAmount
FROM PayrollLog PL, Payroll P
WHERE PL.id = P.PayrollLogID
ORDER BY PaymentDate DESC


SELECT SUM(TotalAmount)
FROM PayrollLog


SELECT T.TCKN, FirstName, LastName, Telephone, Gender, Address, Email, Password, DateCreated, DateUpdated,
		(SELECT COUNT(CustomerTCKN) 
		FROM TellerCustomer TL
		WHERE TL.TellerTCKN = T.TCKN
		GROUP BY TellerTCKN) AS 'MüşteriSayısı'
FROM Teller T, TellerLogin L
WHERE T.TCKN = L.TCKN

SELECT TellerTCKN, COUNT(CustomerTCKN)
FROM TellerCustomer
GROUP BY TellerTCKN
*/
SELECT  t.id AS IşlemNo, CONVERT(varchar(10), t.AccountNo) AS Kaynak, CONVERT(varchar(10), tr.TargetAccountNO) AS Hedef, 'Para Gönderme' AS İşlem, p.Amount AS Tutar, t.Balance AS 'Kaynak Bakiye', (SELECT Balance FROM Account WHERE AccountNo = tr.TargetAccountNo) AS 'Hedef Bakiye', Date
FROM TransactionTbl t, Payment p, TransferTbl tr
WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
UNION
SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Banka', 'Borç Ödeme', p.Amount, t.Balance, null, Date
FROM TransactionTbl t, Payment p, LoanRepayment l
WHERE t.id = p.TransactionID AND l.PaymentID = p.id
UNION
SELECT t.id, 'Customer'+CONVERT(varchar(10), t.AccountNo), CONVERT(varchar(10), t.AccountNo), 'Para Yatırma', p.Amount, null, t.Balance, Date
FROM TransactionTbl t, Payment p, Deposit d
WHERE t.id = p.TransactionID AND d.PaymentID = p.id
UNION
SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Customer'+CONVERT(varchar(10), t.AccountNo), 'Para Çekme', p.Amount, t.Balance, null, Date
FROM TransactionTbl t, Payment p, Withdrawal w
WHERE t.id = p.TransactionID AND w.PaymentID = p.id;


SELECT  * FROM 
(
	(
	SELECT  t.id AS IşlemNo, CONVERT(varchar(10), t.AccountNo) AS Kaynak, CONVERT(varchar(10), tr.TargetAccountNO) AS Hedef, 'Para Gönderme' AS İşlem, p.Amount AS Tutar, t.Balance AS 'Kaynak Bakiye', (SELECT Balance FROM Account WHERE AccountNo = tr.TargetAccountNo) AS 'Hedef Bakiye', Date
	FROM TransactionTbl t, Payment p, TransferTbl tr
	WHERE t.id = p.TransactionID AND tr.PaymentID = p.id
	)			
		UNION ALL
	(
	SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Banka', 'Borç Ödeme', p.Amount, t.Balance, null, Date
	FROM TransactionTbl t, Payment p, LoanRepayment l
	WHERE t.id = p.TransactionID AND l.PaymentID = p.id
	)
		UNION ALL
	(
	SELECT t.id, 'Customer'+CONVERT(varchar(10), t.AccountNo), CONVERT(varchar(10), t.AccountNo), 'Para Yatırma', p.Amount, null, t.Balance, Date
	FROM TransactionTbl t, Payment p, Deposit d
	WHERE t.id = p.TransactionID AND d.PaymentID = p.id
	)
		UNION ALL
	(
	SELECT t.id, CONVERT(varchar(10), t.AccountNo), 'Customer'+CONVERT(varchar(10), t.AccountNo), 'Para Çekme', p.Amount, t.Balance, null, Date
	FROM TransactionTbl t, Payment p, Withdrawal w
	WHERE t.id = p.TransactionID AND w.PaymentID = p.id
	)
)t ORDER BY t.IşlemNo;

SELECT BankDate FROM Date
SELECT CONVERT(date, BankDate, 104) FROM Date

DECLARE @date DATE = (SELECT BankDate FROM Date)

INSERT INTO TransactionTbl (AccountNo, Balance, Date)
VALUES(1000, 1, @date);
