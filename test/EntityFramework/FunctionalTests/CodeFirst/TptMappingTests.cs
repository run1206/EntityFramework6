﻿// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved. See License.txt in the project root for license information.

namespace System.Data.Entity.CodeFirst
{
    using System.Collections.Generic;

    public class TptMappingTests : FunctionalTestBase
    {
        [Table("A")]
        public abstract class A
        {
            public Guid ID { get; set; }
        }

        [Table("AA")]
        public class AA : A
        {
            public BA BAChild { get; set; }
        }

        [Table("AB")]
        public class AB : A
        {
            public BB BBChild { get; set; }
        }

        [Table("B")]
        public abstract class B
        {
            public Guid ID { get; set; }
        }

        [Table("BA")]
        public class BA : B
        {
            public AA Parent { get; set; }
        }

        [Table("BB")]
        public class BB : B
        {
            public AB Parent { get; set; }
        }

        public class ABContext : DbContext
            protected override void OnModelCreating(DbModelBuilder modelBuilder)
    }
}