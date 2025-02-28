﻿using System.Collections.Generic;

namespace DBDefsDumper
{
    class PatternBuilder
    {
        public List<Pattern> patterns = new List<Pattern>();

        public PatternBuilder()
        {
            // Internal only, comment out when reading internal build
            //patterns.Add(
            //new Pattern("8.1.0-internal", new List<string> { "8.1.0" })
            //    .Pointer(Name.DB_NAME)
            //    .FileDataID(Name.FDID)
            //    .FieldReference(Name.NUM_FIELD_IN_FILE)
            //    .RecordSize(Name.RECORD_SIZE)
            //    .FieldReference(Name.NUM_FIELD)
            //    .OptionalFieldReference(Name.ID_COLUMN)
            //    .Boolean(Name.SPARSE_TABLE)
            //    .Pointer(Name.FIELD_OFFSETS)
            //    .Pointer(Name.FIELD_SIZES)
            //    .Pointer(Name.FIELD_TYPES)
            //    .Pointer(Name.FIELD_FLAGS)
            //    .Pointer(Name.FIELD_SIZES_IN_FILE)
            //    .Pointer(Name.FIELD_TYPES_IN_FILE)
            //    .Pointer(Name.FIELD_FLAGS_IN_FILE)
            //    .Uint8(Name.FLAGS_58_21)
            //    .Hash(Name.TABLE_HASH)
            //    .Append("00", "00", "00", "00")
            //    .Hash(Name.LAYOUT_HASH)
            //    .Uint8(Name.FLAGS_68_421)
            //    .FieldReference(Name.FIELD_NUM_IDX_INT)
            //    .FieldReference(Name.FIELD_NUM_IDX_STRING)
            //    .OptionalPointer(Name.FIELD_IDX_INT)
            //    .OptionalPointer(Name.FIELD_IDX_STRING)
            //    .Boolean(Name.HAS_RELATION)
            //    .OptionalFieldReference(Name.FIELD_RELATION)
            //    .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
            //    .OptionalPointer(Name.SORT_FUNC)
            //    .OptionalPointer(Name.DB_NAME_DUPLICATE)
            //    .OptionalPointer(Name.FIELD_NAMES)
            //    .OptionalPointer(Name.FIELD_NAMES_IN_FILE)
            //    .OptionalPointer(Name.SQL_QUERY)
            //);
            
            patterns.Add(
            new Pattern("11.0.0", new() { new VersionRange (new() { "11.0.0", "11.0.2", "1.15.4", "4.4.1", "11.0.5", "11.0.7", "1.15.5", "1.15.6", "11.1.0", "4.4.2", "11.1.5", "5.5.0", "1.15.7", "11.2.0", "3.4.4" }, 54210 ) })
                .Pointer(Name.DB_NAME)
                .FileDataID(Name.FDID)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.UNK_BOOL_11DB2_x1C)
                .Boolean(Name.UNK_BOOL_11DB2_x1D)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .Boolean(Name.HAS_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
            );
            
            patterns.Add(
            new Pattern("10.1.0", new() { new VersionRange (new() { "10.1.0", "10.1.5", "1.14.4", "1.15.0", "3.4.2", "10.1.7", "10.2.0", "3.4.3", "10.2.5", "4.4.0", "1.15.1", "10.2.7", "10.2.6", "1.15.2", "1.15.3" }, 48480 ) })
               .Pointer(Name.DB_NAME)
               .FileDataID(Name.FDID)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .FieldReference(Name.NUM_FIELD)
               .OptionalFieldReference(Name.ID_COLUMN)
               .Boolean(Name.SPARSE_TABLE)
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES)
               .Pointer(Name.FIELD_TYPES)
               .Pointer(Name.FIELD_FLAGS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
               .Pointer(Name.FIELD_FLAGS_IN_FILE)
               .Uint8(Name.FLAGS_58_21)
               .Hash(Name.TABLE_HASH)
               .Hash(Name.SIBLING_TABLE_HASH)
               .Hash(Name.LAYOUT_HASH)
               .Uint8(Name.FLAGS_68_421)
               .FieldReference(Name.FIELD_NUM_IDX_INT)
               .FieldReference(Name.FIELD_NUM_IDX_STRING)
               .OptionalPointer(Name.FIELD_IDX_INT)
               .OptionalPointer(Name.FIELD_IDX_STRING)
               .Boolean(Name.HAS_RELATION)
               .OptionalFieldReference(Name.FIELD_RELATION)
               .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
           );

            patterns.Add(
            new Pattern("8.0.1", new() { new VersionRange (new() { "8.3.0", "8.2.5", "8.2.0", "8.1.5", "8.1.0", "8.0.1", "1.13.2", "1.13.3", "1.13.4", "9.0.1", "1.13.5", "8.3.7", "9.0.2", "1.13.6", "1.13.7", "9.0.5", "2.5.1", "9.1.0", "2.5.2", "1.14.0", "9.1.5", "1.14.1", "9.2.0", "1.14.2", "2.5.3", "2.5.4", "9.2.5", "1.14.3", "3.4.0", "10.0.0", "10.0.2", "9.2.7", "3.4.1", "10.0.5", "10.0.7" }, 26232 ) })
                .Pointer(Name.DB_NAME)
                .FileDataID(Name.FDID)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .Boolean(Name.HAS_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
            new Pattern("8.0.1-prefdid,1.13.0-retail,7.3.5-release",
                        new() { new VersionRange (new() { "8.0.1" }, 25901, 26231 ),
                                new VersionRange (new() { "1.13.0" }),
                                new VersionRange (new() { "7.3.5" }, 25875, 26972 ) })
                .Pointer(Name.DB_NAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .Boolean(Name.HAS_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
            new Pattern("7.3.5-ptr", new() { new VersionRange (new() { "7.3.5" }, 25600, 25864 ) })
                .Pointer(Name.DB_NAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .Boolean(Name.HAS_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
                new Pattern("7.3.{0/2}", new() { new VersionRange (new() { "7.3.0", "7.3.2" } ) }) // note: also matches release-7.3.5 even though different struct
                .Pointer(Name.DB_NAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
                new Pattern("7.2.0-ptr-a", new() { new VersionRange (new() { "7.2.0" } ) })
                .Pointer(Name.DB_NAME)
                .Pointer(Name.DB_CACHE_FILENAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)    // might be dynamic in 7.2.0 builds!?
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
                new Pattern("7.2.0-ptr-b", new() { new VersionRange (new() { "7.2.0" } ) })
                .Pointer(Name.DB_NAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .OptionalPointer(Name.UNK_EXTRA_POINTER_IN_720)
                .Pointer(Name.FIELD_OFFSETS)    // might be dynamic in 7.2.0 builds!?
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
                new Pattern("7.{0,2.5}-release", new() { new VersionRange (new() { "7.2.0", "7.2.5"} ) }) // note: also matches release-7.3.5 even though different struct
                .Pointer(Name.DB_NAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .FieldReference(Name.NUM_FIELD)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)    // might be dynamic in 7.2.0 builds!?
                .Pointer(Name.FIELD_SIZES)
                .Pointer(Name.FIELD_TYPES)
                .Pointer(Name.FIELD_FLAGS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS_IN_FILE)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
                .FieldReference(Name.FIELD_NUM_IDX_INT)
                .FieldReference(Name.FIELD_NUM_IDX_STRING)
                .OptionalPointer(Name.FIELD_IDX_INT)
                .OptionalPointer(Name.FIELD_IDX_STRING)
                .OptionalFieldReference(Name.FIELD_RELATION)
                .OptionalFieldReference(Name.FIELD_RELATION_IN_FILE)
                .OptionalPointer(Name.SORT_FUNC)
                .Boolean(Name.UNKC0)
            );

            patterns.Add(
                new Pattern("7.{0,1}.{0,5}-release", new() { new VersionRange (new() { "7.0.1", "7.0.3", "7.1.0", "7.1.5", "7.2.0" }, 20740, 23476 ) }) //todo: find minbuild
                .Pointer(Name.DB_NAME)
                .Pointer(Name.DB_CACHE_FILENAME)
                .FieldReference(Name.NUM_FIELD_IN_FILE)
                .RecordSize(Name.RECORD_SIZE)
                .OptionalFieldReference(Name.ID_COLUMN)
                .Boolean(Name.SPARSE_TABLE)
                .Pointer(Name.FIELD_OFFSETS)
                .Pointer(Name.FIELD_SIZES_IN_FILE)
                .Pointer(Name.FIELD_TYPES_IN_FILE)
                .Pointer(Name.FIELD_FLAGS)
                .Uint8(Name.FLAGS_58_21)
                .Hash(Name.TABLE_HASH)
                .Hash(Name.SIBLING_TABLE_HASH)
                .Hash(Name.LAYOUT_HASH)
                .Uint8(Name.FLAGS_68_421)
            );

            patterns.Add(
                new Pattern("6.x-db2-experimental", new() { new VersionRange (new() { "6.0.1", "6.0.2", "6.0.3", "6.1.0", "6.1.2", "6.2.0", "6.2.0a", "6.2.1", "6.2.2", "6.2.3", "6.2.4" }, 18125, 21742 ) }) // note: subset of internal-6.0.1-dbc, so conflicts with that
               .Pointer(Name.DB_FILENAME)
               .Pointer(Name.DB_CACHE_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("00", "00", "00", "00")
               .Boolean(Name.UNK_BOOL_601_x24)
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
            );

            patterns.Add(
                new Pattern("6.x-dbc-experimental", new() { new VersionRange (new() { "6.0.1", "6.0.2", "6.0.3", "6.1.0", "6.1.2", "6.2.0", "6.2.0a", "6.2.1", "6.2.2", "6.2.3", "6.2.4" }, 18125, 21742 ) }) // note: subset of internal-6.0.1-dbc, so conflicts with that
               .Pointer(Name.DB_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("00", "00", "00", "00")
               .Append("00", "00", "00", "00")
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
               .Boolean(Name.UNK_BOOL_601dbc_x38)
               .Boolean(Name.UNK_BOOL_601dbc_x39)
            );

            patterns.Add(
                new Pattern("6.0.1-db2-internal", new() { new VersionRange (new() { "6.0.1" }, 18179, 18179 ) }) // note: conflicts with internal-6.0.1-dbc
               .Pointer(Name.DB_FILENAME)
               .Pointer(Name.DB_CACHE_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("00", "00", "00", "00")
               .Boolean(Name.UNK_BOOL_601_x24)
               .Boolean(Name.SPARSE_TABLE)
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
               .Hash(Name.TABLE_HASH)
               .Hash(Name.SIBLING_TABLE_HASH)
               .Uint8(Name.UNK_FLAGS_601_x48_421)
               .FieldReference(Name.FIELD_NUM_IDX_INT)
               .FieldReference(Name.FIELD_NUM_IDX_STRING)
               .OptionalPointer(Name.FIELD_IDX_INT)
               .OptionalPointer(Name.FIELD_IDX_STRING)
               .Append("?", "?", "?", "?") // 68 probably not a column, only 0 or 1
               .Append("?", "?", "?", "?") // 6c
               .Pointer(Name.FIELD_ENCRYPTED)
            );

            patterns.Add(
                new Pattern("6.0.1-dbc-internal", new() { new VersionRange (new() { "6.0.1" }, 18179, 18179 ) }) // note: conflicts with internal-6.0.1-db2
               .Pointer(Name.DB_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("00", "00", "00", "00", "00", "00", "00", "00")
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
               .Boolean(Name.UNK_BOOL_601dbc_x38)
               .Boolean(Name.UNK_BOOL_601dbc_x39)
               .Boolean(Name.UNK_BOOL_601dbc_x3a)
               .Boolean(Name.UNK_BOOL_601dbc_x3b)
               .Append("00", "00", "00", "00")
               .Pointer(Name.FIELD_NAMES_IN_FILE)
               .Pointer(Name.SQL_QUERY)
            );

            patterns.Add(
                new Pattern("5.0.1-dbc-internal", new() { new VersionRange (new() { "5.0.1" } ) }) // note: subset of internal-6.0.1-dbc, so conflicts with that
               .Pointer(Name.DB_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("?", "?", "?", "?")
               .Append("?", "?", "?", "?")
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
            );

            patterns.Add(
                new Pattern("5.0.1-db2-internal", new() { new VersionRange (new() { "5.0.1" } ) }) // note: subset of internal-6.0.1-db2, so conflicts with that and internal-5.0.1-dbc
               .Pointer(Name.DB_FILENAME)
               .Pointer(Name.DB_CACHE_FILENAME)
               .FieldReference(Name.NUM_FIELD_IN_FILE)
               .RecordSize(Name.RECORD_SIZE)
               .Pointer(Name.CONVERT_STRINGREFS)
               .Append("?", "?", "?", "?")
               .Append("?", "?", "?", "?")
               .Pointer(Name.FIELD_OFFSETS)
               .Pointer(Name.FIELD_SIZES_IN_FILE)
               .Pointer(Name.FIELD_TYPES_IN_FILE)
               .Hash(Name.TABLE_HASH)
            );
        }
    }
}
