using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Enums
{
    public enum MenuTypes : byte
    {
        AuthorAdd = 1,
        AuthorEdit,
        AuthorRemove,
        AuthorGetAll,
        AuthorFindByName,
        AuthorGetById,

        BookAdd,
        BookEdit,
        BookRemove,
        BookGetAll,
        BookFindByName,
        BookGetById,

    }
}
