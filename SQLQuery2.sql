/*
SELECT DISTINCT PaymentDate, TotalAmount
FROM PayrollLog PL, Payroll P
WHERE PL.id = P.PayrollLogID
ORDER BY PaymentDate DESC


SELECT SUM(TotalAmount)
FROM PayrollLog
*/

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