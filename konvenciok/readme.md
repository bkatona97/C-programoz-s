# C# 11.hét-feladat
- Ha public vagy protected elementekrőlvan szó:
- Class, record, vagy struct esetén PascalCase (Nagy kezdő betű és minden szó nagybetű)
- Interface esetén kezdjük "I"-vel.
- Public type-ok membereiket(fields, properties, events, methods, és local functions) ugyancsak PascalCase-el kell.
- Helyleíró record-ok esetén is PascalCase-t használjunk.
- Private vagy Internal mezőknél(fields) hasznájunk camelCase-t(kicsi kezdőbetű és egy "_" az elején ezen kívűl minden szó nagybetű).
- Statikus mezőknél amik private-k vagy internal-ok kezdjük a változó nevet s -el és azt követően alsó vonással. ThreadSttic esetén hasnlóan de s helyett t-t írjunk.
- Method-oknál camelCasing.
- bővebben: https://learn.microsoft.com/en-us/dotnet/csharp/fundamentals/coding-style/coding-conventions
