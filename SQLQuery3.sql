SELECT t.id, t.AccountNo AS Kaynak, tr.TargetAccountNo AS Hedef, t.Balance AS Bakiye, p.Amount AS Tutar, Currency, t.Date
FROM TransactionTbl t, Payment p, TransferTbl tr
WHERE t.id = p.TransactionID AND tr.PaymentID = p.id

SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
FROM TransactionTbl t, Payment p, LoanRepayment l
WHERE t.id = p.TransactionID AND l.PaymentID = p.id

SELECT t.id, t.AccountNo, p.Amount, t.Balance, Date
FROM TransactionTbl t, Payment p, Deposit d
WHERE t.id = p.TransactionID AND d.PaymentID = p.id

