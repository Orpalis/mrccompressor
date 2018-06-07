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

        public static readonly Dictionary<ImageSaveAsPDFParameters.ConformanceEnum, string> AvailableOutputPdfVersions = new Dictionary<ImageSaveAsPDFParameters.ConformanceEnum, string>()
        {
            { ImageSaveAsPDFParameters.ConformanceEnum.PDF14, "PDF 1.4" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDF15, "PDF 1.5" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDF16, "PDF 1.6" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDF17, "PDF 1.7" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDF20, "PDF 2.0 (ISO 32000-2)" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA1a, "PDF/A-1A" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA1b, "PDF/A-1B" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA2a, "PDF/A-2A" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA2u, "PDF/A-2U" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA2b, "PDF/A-2B" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA3a, "PDF/A-3A" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA3u, "PDF/A-3U" },
            { ImageSaveAsPDFParameters.ConformanceEnum.PDFA3b, "PDF/A-3B" }
        };


        public static readonly Dictionary<ImageSaveAsPDFParameters.BitonalImageCompressionEnum, string> AvailableBitonalCompressionSchemes = new Dictionary<ImageSaveAsPDFParameters.BitonalImageCompressionEnum, string>()
        {
            { ImageSaveAsPDFParameters.BitonalImageCompressionEnum.Flate, "Flate"},
            { ImageSaveAsPDFParameters.BitonalImageCompressionEnum.CCIT4, "CCIT4"},
            { ImageSaveAsPDFParameters.BitonalImageCompressionEnum.JPEG, "JPEG"},
            { ImageSaveAsPDFParameters.BitonalImageCompressionEnum.JPEG2000, "JPEG2000"},
            { ImageSaveAsPDFParameters.BitonalImageCompressionEnum.JBIG2, "JBIG2"}
        };


        public static readonly Dictionary<ImageSaveAsPDFParameters.ColorImageCompressionEnum, string> AvailableColorCompressionSchemes = new Dictionary<ImageSaveAsPDFParameters.ColorImageCompressionEnum, string>()
        {
            { ImageSaveAsPDFParameters.ColorImageCompressionEnum.Flate, "Flate"},
            { ImageSaveAsPDFParameters.ColorImageCompressionEnum.CCIT4, "CCIT4"},
            { ImageSaveAsPDFParameters.ColorImageCompressionEnum.JPEG, "JPEG"},
            { ImageSaveAsPDFParameters.ColorImageCompressionEnum.JPEG2000, "JPEG2000"},
            { ImageSaveAsPDFParameters.ColorImageCompressionEnum.JBIG2, "JBIG2"}
        };


        public static ImageSaveAsPDFActionConfiguration ImageSaveAsPDFActionConfiguration = new ImageSaveAsPDFActionConfiguration()
        {
            AdvancedImageCompression = ImageSaveAsPDFParameters.AdvancedImageCompressionEnum.MRC
        };


        public static string GetApplicationConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\settings.data";
        }


        public static string GetSaveAsPDFActionConfigurationFilePath()
        {
            return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\" + PASSPORT_PDF_APP_ID + "\\saveAsPDFActionConfiguration.data";
        }
    }
}
