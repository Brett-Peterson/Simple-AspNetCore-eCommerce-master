using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eCommerceSite.Models
{
    public static class MemberDb
    {
        public static Member AddMember(Member m
                                , CommerceContext context)
        {
            //Create insert query
            context.Members.Add(m);
            //Executes insert query
            context.SaveChanges();

            return m;
        }
    }
}
