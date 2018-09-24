/**********************************************************************
 * Project:                  Image To PDF MRC
 * Authors:                 - Evan Carrère.
 *                          - Loïc Carrère.
 *
 * (C) Copyright 2018, ORPALIS.
 ** Licensed under the Apache License, Version 2.0 (the "License");
 ** you may not use this file except in compliance with the License.
 ** You may obtain a copy of the License at
 ** http://www.apache.org/licenses/LICENSE-2.0
 ** Unless required by applicable law or agreed to in writing, software
 ** distributed under the License is distributed on an "AS IS" BASIS,
 ** WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 ** See the License for the specific language governing permissions and
 ** limitations under the License.
 *
 **********************************************************************/

using System;
using Orpalis.Globals.Localization;
using MRCCompressor.Controller;
using PassportPDF.Model;
using PassportPDF.Tools.Framework.Configuration;
using PassportPDF.Tools.WinForm.Models;
using System.Collections.Generic;

namespace MRCCompressor
{
    internal static class MRCCompressorGlobals
    {
        public const string PRODUCT_NAME = "PassportPDF MRC Compressor";
        public const string APP_EXECUTABLE_NAME = "MRCCompressor.exe";
        public const string PASSPORT_PDF_APP_ID = "93892BC8-05AB-419D-A2AB-E388C2EB5F81";
        public const string SOURCE_CODE_URL = "https://github.com/Orpalis/mrccompressor";
        public const PassportPDFDesktopAppInformation.AcceptedInputFilesType INPUT_FILE_TYPE = PassportPDFDesktopAppInformation.AcceptedInputFilesType.Image;

        public static readonly OrpalisLocalizer LabelsLocalizer = new OrpalisLocalizer(AssemblyUtilities.GetManifestResourceStream("res.labels.json"));

        public static readonly Dictionary<ImageSaveAsPDFMRCParameters.ConformanceEnum, string> AvailableOutputPdfVersions = new Dictionary<ImageSaveAsPDFMRCParameters.ConformanceEnum, string>()
        {
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDF14, "PDF 1.4" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDF15, "PDF 1.5" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDF16, "PDF 1.6" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDF17, "PDF 1.7" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDF20, "PDF 2.0" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA1a, "PDF/A-1A" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA1b, "PDF/A-1B" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA2a, "PDF/A-2A" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA2u, "PDF/A-2U" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA2b, "PDF/A-2B" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA3a, "PDF/A-3A" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA3u, "PDF/A-3U" },
            { ImageSaveAsPDFMRCParameters.ConformanceEnum.PDFA3b, "PDF/A-3B" }
        };


        public static readonly Dictionary<ImageSaveAsPDFMRCParameters.BitonalImageCompressionEnum, string> AvailableBitonalCompressionSchemes = new Dictionary<ImageSaveAsPDFMRCParameters.BitonalImageCompressionEnum, string>()
        {
            { ImageSaveAsPDFMRCParameters.BitonalImageCompressionEnum.Flate, "Flate"},
            { ImageSaveAsPDFMRCParameters.BitonalImageCompressionEnum.CCIT4, "CCIT4"},
            { ImageSaveAsPDFMRCParameters.BitonalImageCompressionEnum.JBIG2, "JBIG2"}
        };


        public static readonly Dictionary<ImageSaveAsPDFMRCParameters.ColorImageCompressionEnum, string> AvailableColorCompressionSchemes = new Dictionary<ImageSaveAsPDFMRCParameters.ColorImageCompressionEnum, string>()
        {
            { ImageSaveAsPDFMRCParameters.ColorImageCompressionEnum.Flate, "Flate"},
            { ImageSaveAsPDFMRCParameters.ColorImageCompressionEnum.JPEG, "JPEG"},
            { ImageSaveAsPDFMRCParameters.ColorImageCompressionEnum.JPEG2000, "JPEG2000"},
        };


        public static ImageSaveAsPDFMRCActionConfiguration ImageSaveAsPDFMRCActionConfiguration = new ImageSaveAsPDFMRCActionConfiguration();

        public static string GetApplicationConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\settings.data";
        }


        public static string GetSaveAsPDFMRCActionConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\saveAsPDFMRCActionConfiguration.data";
        }
    }
}
