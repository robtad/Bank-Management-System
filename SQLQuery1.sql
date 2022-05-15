/*
SELECT T.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password 
FROM Teller T, TellerProfile P 
WHERE T.id = P.TellerID
*/
/**/
/*
SELECT T.id, TCKN, Name, Surname, Gender, Telephone, Address, Email, Password 
FROM Teller T, TellerProfile P 
WHERE T.id = P.TellerID AND Surname = "Dal"
*/

--DELETE FROM Teller WHERE id = 9
/*
SELECT c1.TellerID, COUNT(c1.TellerID)
FROM Customer c1, Customer c2
WHERE c1.Id = c2.Id
GROUP BY c1.TellerID

select TellerID, COUNT(TellerID) AS MOST_FREQUENT
from customer
GROUP BY TellerID
ORDER BY COUNT(TellerID) asc
*/

SELECT COUNT(C.TellerID)
FROM Teller T, Customer C
WHERE T.id = C.TellerID
GROUP BY C.TellerID