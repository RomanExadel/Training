﻿namespace Training.Service
{
    public class Constants
    {
        public static class ImportFileOffsets
        {
            public const int AUTOPARTNAME_COLUMN_OFFSET = 0;
            public const int AUTOPARTPRICE_COLUMN_OFFSET = 1;
            public const int AUTOPARTDESCRIPTION_COLUMN_OFFSET = 2;
            public const int PRODUCERNAME_COLUMN_OFFSET = 3;
            public const int CARMODEL_COLUMN_OFFSET = 4;
            public const int CARISSUEYEAR_COLUMN_OFFSET = 5;
            public const int CARENGINE_COLUMN_OFFSET = 6;
            public const int VendorName_COLUMN_OFFSET = 7;
        }

        public static class ImportFileStructure
        {
            public const string AutopartName_COLUMN_NAME = nameof(AutopartName_COLUMN_NAME);
            public const string AutopartPrice_COLUMN_NAME = nameof(AutopartPrice_COLUMN_NAME);
            public const string AutopartDescription_COLUMN_NAME = nameof(AutopartDescription_COLUMN_NAME);
            public const string Producer_COLUMN_NAME = nameof(Producer_COLUMN_NAME);
            public const string CarModel_COLUMN_NAME = nameof(CarModel_COLUMN_NAME);
            public const string CarIssueYear_COLUMN_NAME = nameof(CarIssueYear_COLUMN_NAME);
            public const string CarEngine_COLUMN_NAME = nameof(CarEngine_COLUMN_NAME);
            public const string VendorName_COLUMN_NAME = nameof(VendorName_COLUMN_NAME);
        }
    }
}
