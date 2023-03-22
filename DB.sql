USE [CustomerDB]
GO
INSERT [dbo].[Customer] ([customerId], [firstName], [lastName], [address], [age], [annualSalary], [PIN], [accountDisabled], [overdraft]) VALUES (19874123, N'Tom', N'Riley', N'23 SHU Street', 19, 40000, 1234, 0, 4000)
INSERT [dbo].[Customer] ([customerId], [firstName], [lastName], [address], [age], [annualSalary], [PIN], [accountDisabled], [overdraft]) VALUES (19875226, N'Josh', N'Doyle', N'14 Cantor Crescent', 20, 37500, 1111, 0, 3750)
INSERT [dbo].[Customer] ([customerId], [firstName], [lastName], [address], [age], [annualSalary], [PIN], [accountDisabled], [overdraft]) VALUES (19878981, N'Jordan', N'Chester', N'25 Addsett Avenue', 30, 28000, 9999, 0, 0)
INSERT [dbo].[Customer] ([customerId], [firstName], [lastName], [address], [age], [annualSalary], [PIN], [accountDisabled], [overdraft]) VALUES (19881172, N'Azeez', N'Ogbeni', N'41 Cantor Crescent', 20, 32000, 7777, 0, 3200)
GO
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (88, 1, N'Current Account', 1620.41, 1, 19874123)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (89, 2, N'Simple Deposit', 5150, 1, 19874123)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (90, 3, N'Longterm Deposit', 23250, 1, 19874123)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (91, 1, N'Current Account', 1800, 1, 19875226)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (92, 2, N'Simple Deposit', 5500, 1, 19875226)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (93, 3, N'Longterm Deposit', 23000, 1, 19875226)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (94, 1, N'Current Account', 948.88, 1, 19878981)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (95, 2, N'Simple Deposit', 0, 0, 19878981)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (96, 3, N'Longterm Deposit', 0, 0, 19878981)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (97, 1, N'Current Account', 862.45, 1, 19881172)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (98, 2, N'Simple Deposit', 7500, 1, 19881172)
INSERT [dbo].[BankAccount] ([accountId], [accountType], [accountName], [balance], [isActive], [customerId]) VALUES (99, 3, N'Longterm Deposit', 0, 0, 19881172)
GO
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51000, CAST(N'2022-06-12' AS Date), 89, N'Transfer', 88, 250, 19874123)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51001, CAST(N'2022-06-12' AS Date), 92, N'Transfer', 91, 100, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51002, CAST(N'2022-06-12' AS Date), 92, N'Withdrawal', NULL, 150, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51003, CAST(N'2022-06-12' AS Date), 94, N'Withdrawal', NULL, 20, 19878981)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51004, CAST(N'2022-06-12' AS Date), 94, N'Withdrawal', NULL, 70, 19878981)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51005, CAST(N'2022-06-12' AS Date), 97, N'Withdrawal', NULL, 60, 19881172)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51006, CAST(N'2022-06-12' AS Date), 98, N'Transfer', 97, 500, 19881172)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51008, CAST(N'2022-06-12' AS Date), 91, N'Withdrawal', NULL, 150, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51009, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 92, 2000, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51010, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 93, 6500, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51011, CAST(N'2022-06-12' AS Date), 91, N'Withdrawal', NULL, 10, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51012, CAST(N'2022-06-12' AS Date), 91, N'Withdrawal', NULL, 250, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51013, CAST(N'2022-06-12' AS Date), 92, N'Transfer', 91, 150, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51014, CAST(N'2022-06-12' AS Date), 91, N'Withdrawal', NULL, 150, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51015, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 93, 1000, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51016, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 92, 400, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51017, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 92, 1500, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51018, CAST(N'2022-06-12' AS Date), 91, N'Withdrawal', NULL, 190, 19875226)
INSERT [dbo].[Transactions] ([transactionId], [date], [accountId], [type], [toAccountId], [amount], [customerId]) VALUES (51019, CAST(N'2022-06-12' AS Date), 91, N'Transfer', 93, 1200, 19875226)
GO
INSERT [dbo].[AASLogin] ([firstName], [lastName], [username], [password]) VALUES (N'Tom', N'Riley', N'triley', N'yelir')
INSERT [dbo].[AASLogin] ([firstName], [lastName], [username], [password]) VALUES (N'Josh', N'Doyle', N'jdoyle', N'elyod')
INSERT [dbo].[AASLogin] ([firstName], [lastName], [username], [password]) VALUES (N'Jordan', N'Chester', N'jchester', N'retsehc')
GO
