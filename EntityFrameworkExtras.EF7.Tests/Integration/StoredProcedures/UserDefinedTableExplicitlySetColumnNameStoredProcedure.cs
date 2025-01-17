﻿using System.Collections.Generic;
using System.Data;

namespace EntityFrameworkExtras.EF7.Tests.Integration.StoredProcedures
{
    [StoredProcedure("UserDefinedTableStoredProcedure")]
    public class UserDefinedTableExplicitlySetColumnNameStoredProcedure
    {
        [StoredProcedureParameter(SqlDbType.Udt)]
        public List<ExplicitySetColumnNamesUserDefinedTable> UserDefinedTableParameter { get; set; }
    }
}