# Log request vs response SQL Server

## Monolítico

### tblRequestResponse

| Nome                | Tipo           | Nulo | PK  |
| :------------------ | :------------- | :--: | :-: |
| `Id`                | `bigint`       |      | `x` |
| `RequestContent`    | `varchar(max)` |      |     |
| `RequestTimestamp`  | `datetime`     |      |     |
| `ResponseContent`   | `varchar(max)` | `x`  |     |
| `ResponseTimestamp` | `datetime`     | `x`  |     |
| `ResponseTimeMs`    | `int`          | `x`  |     |
| `RowTimestamp`      | `datetime`     |      |     |
