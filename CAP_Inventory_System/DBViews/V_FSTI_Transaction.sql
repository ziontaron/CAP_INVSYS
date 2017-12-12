USE [CAPA_INV]
GO

IF  EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[V_FSTI_Transaction]'))
DROP VIEW [dbo].[V_FSTI_Transaction]
GO

USE [CAPA_INV]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[V_FSTI_Transaction]
AS
SELECT     dbo.InventoryEvent.InventoryEventName, dbo.Ticket.TicketCounter, dbo.FSTI_Transactions.*
FROM         dbo.Ticket INNER JOIN
                      dbo.TicketCount ON dbo.Ticket.TicketKey = dbo.TicketCount.TicketKey INNER JOIN
                      dbo.InventoryEvent ON dbo.Ticket.InventoryEventKey = dbo.InventoryEvent.InventoryEventKey INNER JOIN
                      dbo.FSTI_Transactions ON dbo.TicketCount.TagCountKey = dbo.FSTI_Transactions.TagCountKey

GO