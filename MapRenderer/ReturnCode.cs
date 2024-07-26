// Part of hCraft | Copyright (c) 2009-2014 Matvei Stefarov <me@matvei.org> | BSD-3 | See LICENSE.txt

namespace hCraft.MapRenderer {
    enum ReturnCode {
        Success = 0,
        ArgumentError = 1,
        UnrecognizedImporter = 2,
        InputPathNotFound = 4,
        PathError = 5,
        UnsupportedLoadFormat = 6,
        UnsupportedSaveFormat = 7
    }
}