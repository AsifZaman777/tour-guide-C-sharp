CREATE TABLE [dbo].[TRANSPORT_INFO] (
    [SPOT_CODE] VARCHAR (20) NOT NULL,
    [H_ac]      INT          NULL,
    [H_nac]     INT          NULL,
    [E_ac]      INT          NULL,
    [E_nac]     INT          NULL,
    [S_ac]      INT          NULL,
    [S_nac]     INT          NULL, 
    CONSTRAINT [PK_TRANSPORT_INFO] PRIMARY KEY ([SPOT_CODE])
);

