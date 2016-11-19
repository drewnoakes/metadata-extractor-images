# ImageTestSuite &mdash; TIFF

This folder contains images from the `imagetestsuite` located at:

https://code.google.com/archive/p/imagetestsuite/

Notes from that project below.

---

# Introduction

The TIFF testsuite is a collection of [TIFF images](http://en.wikipedia.org/wiki/Tagged_Image_File_Format) from publicly available sources, intended to help verify the correct operation of TIFF image decoders when presented with malformed or esoteric characteristics.

It is not the intention of this testsuite to verify the correct rendering of images, but rather to ensure safe operation when presented with malformed data, esoteric characteristics, edge cases, and pathological input.

Your decoder or application should gracefully handle any errors while attempting to render these images. To read more about how these testsuites are generated and their intended use, see AboutTestSuite.

# Specification

These images were selected based on the number of execution paths explored with [tiff-4.0.0beta3](http://www.libtiff.org).

Approximately 8797 unique lines of code are executed when decoding the testsuite using tiff-4.0.0beta3.

## Coverage

![](http://chart.apis.google.com/chart?chs=500x250&chd=t:0,0,38,47,0,67,661,194,2343,0,29,11,12,901,0,654,296,353,0,1439,159,60,0,224,437,191,132,59,105,148,100,0,11,0,126&chl=stat.h|sysmacros.h|tif_aux.c|tif_close.c|tif_codec.c|tif_compress.c|tif_dir.c|tif_dirinfo.c|tif_dirread.c|tif_dirwrite.c|tif_dumpmode.c|tif_error.c|tif_extension.c|tif_fax3.c|tif_flush.c|tif_jpeg.c|tif_luv.c|tif_lzw.c|tif_next.c|tif_ojpeg.c|tif_open.c|tif_packbits.c|tif_pixarlog.c|tif_predict.c|tif_print.c|tif_read.c|tif_strip.c|tif_swab.c|tif_thunder.c|tif_tile.c|tif_unix.c|tif_version.c|tif_warning.c|tif_write.c|tif_zip.c&cht=p&chtt=Distribution%20of%20Executed%20Lines%20by%20File&ft=.png)
![](http://chart.apis.google.com/chart?chs=500x250&chd=t:12,9,184,19,34,110,592,282,2122,2095,33,25,47,838,58,762,1074,358,82,601,219,164,1340,381,129,360,110,69,5,80,27,3,25,535,148&chl=stat.h|sysmacros.h|tif_aux.c|tif_close.c|tif_codec.c|tif_compress.c|tif_dir.c|tif_dirinfo.c|tif_dirread.c|tif_dirwrite.c|tif_dumpmode.c|tif_error.c|tif_extension.c|tif_fax3.c|tif_flush.c|tif_jpeg.c|tif_luv.c|tif_lzw.c|tif_next.c|tif_ojpeg.c|tif_open.c|tif_packbits.c|tif_pixarlog.c|tif_predict.c|tif_print.c|tif_read.c|tif_strip.c|tif_swab.c|tif_thunder.c|tif_tile.c|tif_unix.c|tif_version.c|tif_warning.c|tif_write.c|tif_zip.c&cht=p&chtt=Distribution%20of%20Unexecuted%20Lines%20by%20File&ft=.png)

### Coverage Gaps

The majority of the unexecuted code is from the writing routines, whice are largely unused during decoder testing. A large portion of the code also handles runtime allocation failure.

# Testsuite Contents
## Legend

|| *Tag* || *Description*  ||
|| *T*   || *Trivial*<br>Any artistic/creative content contained in the image is believed to be ineligible for copyright, as it's trivial (solid colour, single pixel, simple shapes or patterns, etc.) (please note, [IANAL](http://en.wikipedia.org/wiki/IANAL)). See also, TrivialContent. ||
|| *F*   || *Free*<br>The image is believed to be compatible with common free software distribution guidelines, such as [PD](http://en.wikipedia.org/wiki/Public_domain), [CC](http://en.wikipedia.org/wiki/Creative_Commons), or [GFDL](http://en.wikipedia.org/wiki/GFDL). See also, ImageFreedom.||
|| *O*   || *Origin Unkown*<br>The original creator or source of the image is currently unknown. Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you know the origin or creator, or can provide a replacement image. See also, OriginUnknown. ||
|| *N*   || *NSFW (Not Safe For Work)*<br>The image may contain potentially objectionable content. Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you have a suitable replacement image. See also, ObjectionableContent. ||
|| *U*   || *Fair Use / Fair Dealing*<br>The original source image is known to be distributed under a restrictive license, however, it is believed that it's use in verifying the correct operation of image decoders is [http://en.wikipedia.org/wiki/Fair_use fair use]/[http://en.wikipedia.org/wiki/Fair_dealing fair dealing] (non-commercial research) (please note, [IANAL](http://en.wikipedia.org/wiki/IANAL)). Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you have a suitable replacement image. See also, CopyrightIssues. ||

## Naming Convention

Images are named based on the md5 checksum of the original source image, prefixed
with modifier letters, for example

```
c-m8-d41d8cd98f00b204e9800998ecf8427e.tif
```

This is an 8th generation mutation of a source image with checksum
d41d8cd98f00b204e9800998ecf8427e, and at least one error has been
corrected.

## Images

### 023c970a2a16794f9e51101f76d3bf4d.tif

  * Origin: {{{http://www.weatherchannel.com.au/tippingmedia/3.tif}}}

#### Notes

```
TIFF Directory at offset 0x2e9e6 (190950)
  Subfile Type: (0 = 0x0)
  Image Width: 689 Image Length: 217
  Resolution: 96, 96 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  YCbCr Positioning: 0 (0x0)
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 217
  Planar Configuration: single image plane
  Page Number: 1-1
  White Point: 0-0
  PrimaryChromaticities: 0.000000,0.000000,0.000000,0.000000,0.000000,0.000000
  YCbCrCoefficients: 0.000000,0.000000,0.000000
  Reference Black/White:
     0:     0     0
     1:     0     0
     2:     0     0
  EXIFIFDOffset: 0x108
  Predictor: horizontal differencing 2 (0x2)

```
### 034ed0549f9046b9c370ac26550a60da.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x18 (24)
  Subfile Type: (0 = 0x0)
  Image Width: 664 Image Length: 813
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 1
  Compression Scheme: None
  Photometric Interpretation: min-is-white
  Thresholding: halftone or dithered scan
  Samples/Pixel: 1
  Rows/Strip: 813
  Planar Configuration: single image plane

```
### 0c84d07e1b22b76f24cccc70d8788e4a.tif

  * Origin: {{{http://downloads.bistum-augsburg.de/6/562/1/70846786833481925294.tif}}}

#### Notes

```
TIFF Directory at offset 0x440ec (278764)
  Subfile Type: (0 = 0x0)
  Image Width: 246 Image Length: 345
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 345
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS2 Windows
  DateTime: 2008:03:09 23:30:21
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 8550 bytes
  EXIFIFDOffset: 0x441f0
TIFF Directory at offset 0x47116 (291094)
  Subfile Type: (0 = 0x0)
  Image Width: 1748 Image Length: 2480
  Resolution: 300, 300 pixels/inch
  Position: 0, 0
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 293
  Planar Configuration: single image plane
  SubIFD Offsets: 294106
  Model: CanoScan N650U/N656U
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2008:03:09 13:07:32
  Artist: Rosa
TIFF Directory at offset 0x4b504 (308484)
  Subfile Type: (0 = 0x0)
  Image Width: 1748 Image Length: 2480
  Resolution: 300, 300 pixels/inch
  Position: 0, 0
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 293
  Planar Configuration: single image plane
  SubIFD Offsets: 311882
  Model: CanoScan N650U/N656U
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2008:03:09 13:08:27
  Artist: Rosa
TIFF Directory at offset 0x4f6a4 (325284)
  Subfile Type: (0 = 0x0)
  Image Width: 1748 Image Length: 2480
  Resolution: 300, 300 pixels/inch
  Position: 0, 0
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 293
  Planar Configuration: single image plane
  SubIFD Offsets: 328042
  Model: CanoScan N650U/N656U
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2008:03:09 13:09:07
  Artist: Rosa

```
### 0ceffbda821c7564352b313bed43f7c7.tif

  * Origin: {{{http://wko.at/wknoe/rp/gdb/bacopa.tif}}}

#### Notes

```
TIFF Directory at offset 0x108bc (67772)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 2206
  Resolution: 204, 196 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 146
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.00P, (c) Wang Labs, Inc. 1990, 1991
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x8 (8)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2230
  Resolution: 204, 196
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: msb-to-lsb
  Planar Configuration: single image plane
  Page Number: 1-3
  Software: Topcall TIFF Writer V.: 2.12.08 / Mar  2 2000
TIFF Directory at offset 0x7f0c (32524)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2292
  Resolution: 204, 196
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: msb-to-lsb
  Planar Configuration: single image plane
  Page Number: 2-3
  Software: Topcall TIFF Writer V.: 2.12.08 / Mar  2 2000

```
### m1-108af7a96a2efa82a0cee0f200e6b9a2.tif

### m2-108af7a96a2efa82a0cee0f200e6b9a2.tif

### m3-108af7a96a2efa82a0cee0f200e6b9a2.tif

  * Origin: {{{https://courses.washington.edu/art483/site/images/livingrobot-rear.tif}}}

#### Notes

```
m1-108af7a96a2efa82a0cee0f200e6b9a2.tif:
TIFF Directory at offset 0xbd0 (3024)
  Subfile Type: (0 = 0x0)
  Image Width: 800 Image Length: 3036676696
  Resolution: 150, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 600
  Planar Configuration: single image plane
  Make: NIKON
  Model: E775
  Software: E775v1.1u
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 88 bytes
  ICC Profile: <present>, 1304 bytes
  EXIFIFDOffset: 0xcde
TIFF Directory at offset 0xcde (3294)
  ExposureTime: 0.192308
  FNumber: 2.800000
  ExposureProgram: 2
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2006:11:23 14:46:39
  DateTimeDigitized: 2006:11:23 14:46:39
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 3.000000
  ExposureBiasValue: 0.000000
  MaxApertureValue: 3.500000
  MeteringMode: 5
  LightSource: 0
  Flash: 0
  FocalLength: 5.800000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 1
  PixelXDimension: 1600
  PixelYDimension: 1200
m2-108af7a96a2efa82a0cee0f200e6b9a2.tif:
TIFF Directory at offset 0xbd0 (3024)
  Subfile Type: (0 = 0x0)
  Image Width: 800 Image Length: 600
  Resolution: 150, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 600
  Planar Configuration: single image plane
  Model: E775
  Software: E775v1.1u
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 88 bytes
  ICC Profile: <present>, 1304 bytes
  EXIFIFDOffset: 0xcde
TIFF Directory at offset 0xcde (3294)
  ExposureTime: 0.192308
  FNumber: 2.800000
  ExposureProgram: 2
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2006:11:23 14:46:39
  DateTimeDigitized: 2006:11:23 14:46:39
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 0.000000
  ExposureBiasValue: 0.000000
  MaxApertureValue: 3.500000
  MeteringMode: 5
  LightSource: 0
  Flash: 0
  FocalLength: 5.800000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 1
  PixelXDimension: 1600
  PixelYDimension: 1200
m3-108af7a96a2efa82a0cee0f200e6b9a2.tif:
TIFF Directory at offset 0xbd0 (3024)
  Subfile Type: (0 = 0x0)
  Image Width: 800 Image Length: 600
  Resolution: 150, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 600
  Planar Configuration: single image plane
  Model: E775
  Software: E775v1.1u
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 88 bytes
  ICC Profile: <present>, 1304 bytes
  EXIFIFDOffset: 0xcde

```
### m1-14847ce6f5fab0774dae9ad4fba31316.tif

### m2-14847ce6f5fab0774dae9ad4fba31316.tif

  * Origin: {{{http://www.camarasertaozinho.sp.gov.br/images/010003535.tif}}}

#### Notes

```
m1-14847ce6f5fab0774dae9ad4fba31316.tif:
TIFF Directory at offset 0x130d2 (78034)
  Image Width: 3296 Image Length: 4672
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 212
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  SMax Sample Value: 4672
  Planar Configuration: single image plane
  Page Number: 0-0
m2-14847ce6f5fab0774dae9ad4fba31316.tif:
TIFF Directory at offset 0x130d2 (78034)
  Image Width: 3296 Image Length: 4672
  Resolution: 400, 0 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 4672
  SMax Sample Value: 78026
  Planar Configuration: single image plane
  Page Number: 0-0

```
### 16f2a7e9adcda96170bc1fa873e275c1.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x11866 (71782)
  Image Width: 333 Image Length: 225
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 16
  Sample Format: signed integer
  Compression Scheme: SGILog
  Photometric Interpretation: CIE Log2(L)
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 8
  Planar Configuration: single image plane
  Sample to Nits conversion factor: 1.7900e+02

```
### 1af8e95246f4cfa4e5e58f67d6428ea3.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x1208 (4616)
  Subfile Type: (0 = 0x0)
  Image Width: 160 Image Length: 160
  Resolution: 100, 100 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  YCbCr Positioning: centered
  Samples/Pixel: 3
  Rows/Strip: 160
  Planar Configuration: single image plane
  Software: HP IL v1.1
  YCbCrCoefficients: 0.299000,0.587000,0.114000
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 8
  JpegInterchangeFormatLength: 4608
  JpegQTables: 34 103 103
  JpegDcTables: 172 205 205
  JpegAcTables: 238 421 421
  JpegProc: 1
  JpegRestartInterval: 0

```
### 221209eb0a273029efa18f4c61f6628a.tif

  * Origin: {{{http://drgarywilson.com/images/googlemap.tiff}}}

#### Notes

```
TIFF Directory at offset 0x3ed7c (257404)
  Image Width: 500 Image Length: 396
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Sample Format: unsigned integer
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<unassoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 65
  Planar Configuration: single image plane
  Software: Pixelmator 1.1.4
  DateTime: 2008-06-16 16:39:39 
  RichTIFFIPTC Data: <present>, 36 bytes
  EXIFIFDOffset: 0x8
  ICC Profile: <present>, 3880 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x8 (8)
  ColorSpace: 1
  PixelXDimension: 500
  PixelYDimension: 396

```
### m1-26f459b3eb2a285626b849d6950db7ab.tif

  * Origin: {{{http://lexicon.ff.cuni.cz/tiff/oi_zoega/b0244.tiff}}}

#### Notes

```

```
### m1-2743db7c68f091ddc61dcd582febff2d.tif

  * Origin: {{{http://211.157.104.92/books/xx/2001/0148/003/00214615/000001.tif}}}

#### Notes

```

```
### 27d40bc5f25d8382b890766accb28cf7.tif

  * Origin: {{{http://www.swisswater.info/download/aquaclic-clima/clima-brausen-diverse-quadratisch.tif}}}

#### Notes

```
TIFF Directory at offset 0x1dbd21 (1948961)
  Subfile Type: (0 = 0x0)
  Image Width: 1110 Image Length: 1110
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Extra Samples: 1<unassoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 5
  Rows/Strip: 2
  Planar Configuration: single image plane
  ImageDescription: image description                
  Predictor: horizontal differencing 2 (0x2)

```
### m1-299787ea764c0a88bc481364eded5556.tif

### m2-299787ea764c0a88bc481364eded5556.tif

### m3-299787ea764c0a88bc481364eded5556.tif

### m4-299787ea764c0a88bc481364eded5556.tif

### m5-299787ea764c0a88bc481364eded5556.tif

### m6-299787ea764c0a88bc481364eded5556.tif

### m7-299787ea764c0a88bc481364eded5556.tif

### m8-299787ea764c0a88bc481364eded5556.tif

  * Origin: {{{http://www.theprosadvantage.com/client_content/listings/docs/18920-sellersdisclosure.tif}}}

#### Notes

```
m1-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Subfile Type: multi-page document (8126466 = 0x7c0002)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 98
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Page Number: 0-9
  Software: NaturalFax
  DateTime: 2008w09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x10232 (66098)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 12387393
  Planar Configuration: single image plane
  Page Number: 1-9
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x15fda (90074)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1090
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1090
  Planar Configuration: single image plane
  Page Number: 2-14601
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x1f054 (127060)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  Page Number: 3-9
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x291a2 (168354)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1086
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1086
  Planar Configuration: single image plane
  Page Number: 4-9
  Software: NaturalFax
  DateTime: 2008:0:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x3097a (199034)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1090
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1077
  Planar Configuration: single image plane
  Page Number: 5-9
  Software: NaturalFax
  DateTime: í008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x37e74 (228980)
  Image Width: 1728 Image Length: 1086
  Resolution: 204, 98
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 1086
  Planar Configuration: single image plane
  Page Number: 6-9
  Software: NaturalFaxe
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
m2-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Subfile Type: multi-page document (8126466 = 0x7c0002)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 98
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Page Number: 1536-9
  DateTime: 2008w09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x10232 (66098)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 12387393
  Planar Configuration: single image plane
  Page Number: 1-9
  Software: NaturalFax
  DateTime: 2008:0Z:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x15fda (90074)
  Image Width: 1728 Image Length: 1090
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1090
  Planar Configuration: single image plane
  Page Number: 2-14601
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x1f054 (127060)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1089
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  Page Number: 3-9
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x291a2 (168354)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1086
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1086
  Planar Configuration: single image plane
  Page Number: 4-9
  Software: NaturalFax
  DateTime: 2008:0:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
m3-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1547 Image Length: 1087
  Resolution: 0, 98 pixels/inch
  Compression Scheme: None
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Page Number: 0-9
  Software: 
  DateTime: 2û08:09:08 09:42:29
m4-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Image Width: 1728 Image Length: 1087
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Software: NaturalFax˜
  DateTime: 2008:09:08 09:42À29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
m5-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: 28163 (0x6e03)
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
TIFF Directory at offset 0x10232 (66098)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  Page Number: 1-9
  Software: Nat[ralFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
m6-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 2.46466e-08 pixels/inch
  Position: 5, 0
  Bits/Sample: 1
  Compression Scheme: 28163 (0x6e03)
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
m7-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 0 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Planar Configuration: single image plane
  Page Number: 0-9
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x10232 (66098)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  Page Number: 1-9
  Software: NaturalFax
  DateTime: 
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
TIFF Directory at offset 0x15fda (90074)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1090
  Resolution: 204, 0.0127588 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1090
  Planar Configuration: single image plane
  Page Number: 2-9
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x1f054 (127060)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  Software: NaturalFax
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
m8-299787ea764c0a88bc481364eded5556.tif:
TIFF Directory at offset 0x9fec (40940)
  Image Width: 1728 Image Length: 1087
  Resolution: 204, 0 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1087
  Planar Configuration: single image plane
  Page Number: 0-9
  Software: NaturalFax
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0x10232 (66098)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1089
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 1089
  Planar Configuration: single image plane
  DateTime: 2008:09:08 09:42:29
  Group 3 Options: 2-d encoding+EOL padding (5 = 0x5)
  Fax Data: clean (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0

```
### 2b27b742e68d313d5ea4abd7847cbff4.tif

  * Origin: {{{http://mp3.news.com.au/bcm/romastreet.tiff}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 3432 Image Length: 2394
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2400
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 368
  JpegInterchangeFormatLength: 507201
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x7becc (507596)
  Subfile Type: (0 = 0x0)
  Image Width: 3426 Image Length: 2380
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 507956
  JpegInterchangeFormatLength: 516472
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0xfa1c4 (1024452)
  Subfile Type: (0 = 0x0)
  Image Width: 3414 Image Length: 2380
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 1024812
  JpegInterchangeFormatLength: 400675
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x15c068 (1425512)
  Subfile Type: (0 = 0x0)
  Image Width: 3422 Image Length: 2378
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 1425872
  JpegInterchangeFormatLength: 349876
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x1b189c (1775772)
  Subfile Type: (0 = 0x0)
  Image Width: 3426 Image Length: 2376
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 1776132
  JpegInterchangeFormatLength: 364728
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x20aad4 (2140884)
  Subfile Type: (0 = 0x0)
  Image Width: 3396 Image Length: 2376
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 2141244
  JpegInterchangeFormatLength: 561210
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x293c90 (2702480)
  Subfile Type: (0 = 0x0)
  Image Width: 3418 Image Length: 2386
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2392
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 2702840
  JpegInterchangeFormatLength: 569066
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x31ecfc (3271932)
  Subfile Type: (0 = 0x0)
  Image Width: 3426 Image Length: 2384
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 3272292
  JpegInterchangeFormatLength: 554385
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x3a6410 (3826704)
  Subfile Type: (0 = 0x0)
  Image Width: 3418 Image Length: 2378
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 3827064
  JpegInterchangeFormatLength: 542052
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x42aaf4 (4369140)
  Subfile Type: (0 = 0x0)
  Image Width: 3402 Image Length: 2380
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 4369500
  JpegInterchangeFormatLength: 403762
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x48d5a8 (4773288)
  Subfile Type: (0 = 0x0)
  Image Width: 3426 Image Length: 2394
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2400
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 4773648
  JpegInterchangeFormatLength: 382099
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x4eabbc (5155772)
  Subfile Type: (0 = 0x0)
  Image Width: 3422 Image Length: 2382
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 5156132
  JpegInterchangeFormatLength: 371374
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x5457ec (5527532)
  Subfile Type: (0 = 0x0)
  Image Width: 3414 Image Length: 2382
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 5527892
  JpegInterchangeFormatLength: 354829
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x59c37c (5882748)
  Subfile Type: (0 = 0x0)
  Image Width: 3422 Image Length: 2378
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 5883108
  JpegInterchangeFormatLength: 369771
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x5f6968 (6252904)
  Subfile Type: (0 = 0x0)
  Image Width: 3418 Image Length: 2380
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 6253264
  JpegInterchangeFormatLength: 363254
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x64f5e0 (6616544)
  Subfile Type: (0 = 0x0)
  Image Width: 3394 Image Length: 2374
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 6616904
  JpegInterchangeFormatLength: 356390
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x6a6788 (6973320)
  Subfile Type: (0 = 0x0)
  Image Width: 3422 Image Length: 2380
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 6973680
  JpegInterchangeFormatLength: 359661
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x6fe5f8 (7333368)
  Subfile Type: (0 = 0x0)
  Image Width: 3422 Image Length: 2378
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 7333728
  JpegInterchangeFormatLength: 461910
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x76f3d0 (7795664)
  Subfile Type: (0 = 0x0)
  Image Width: 3418 Image Length: 2374
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 7796024
  JpegInterchangeFormatLength: 470044
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x7e216c (8266092)
  Subfile Type: (0 = 0x0)
  Image Width: 3420 Image Length: 2378
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2384
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 8266452
  JpegInterchangeFormatLength: 355030
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x838dc4 (8621508)
  Subfile Type: (0 = 0x0)
  Image Width: 3418 Image Length: 2374
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 8621868
  JpegInterchangeFormatLength: 424049
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x8a07b8 (9045944)
  Subfile Type: (0 = 0x0)
  Image Width: 3420 Image Length: 2374
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2376
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 9046304
  JpegInterchangeFormatLength: 376325
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x8fc740 (9422656)
  Subfile Type: (0 = 0x0)
  Image Width: 3394 Image Length: 2368
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 2368
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.07.00
  JpegInterchangeFormat: 9423016
  JpegInterchangeFormatLength: 653552
  JpegProc: 1
  JpegRestartInterval: 0

```
### m1-336db1cd76254717eb50a8602b651fbf.tif

### m2-336db1cd76254717eb50a8602b651fbf.tif

### m3-336db1cd76254717eb50a8602b651fbf.tif

### m4-336db1cd76254717eb50a8602b651fbf.tif

### m5-336db1cd76254717eb50a8602b651fbf.tif

### m6-336db1cd76254717eb50a8602b651fbf.tif

### m7-336db1cd76254717eb50a8602b651fbf.tif

### m8-336db1cd76254717eb50a8602b651fbf.tif

  * Origin: {{{http://li.ru/go?www.kbural.ru/files/petrostil.tif}}}

#### Notes

```
m1-336db1cd76254717eb50a8602b651fbf.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 2306 Image Length: 3111
  Resolution: 300, 0
  Compression Scheme: 198 (0xc6)
  Samples/Pixel: 1
  Rows/Strip: 28
  Planar Configuration: single image plane
  Photoshop Data: <present>, 4598 bytes
m2-336db1cd76254717eb50a8602b651fbf.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2306 Image Length: 3111
  Resolution: 0.608069, 0 pixels/inch
  Compression Scheme: LZW
  Samples/Pixel: 1
  Planar Configuration: single image plane
  Software: 
  Photoshop Data: <present>, 4598 bytes
  Predictor: none 1 (0x1)
m3-336db1cd76254717eb50a8602b651fbf.tif:
m4-336db1cd76254717eb50a8602b651fbf.tif:
m5-336db1cd76254717eb50a8602b651fbf.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2306 Image Length: 3111
  Resolution: 300, 300 pixels/inch
  Compression Scheme: LZW
  Samples/Pixel: 1
  Rows/Strip: 28
  Planar Configuration: single image plane
  Photoshop Data: <present>, 4598 bytes
  Predictor: none 1 (0x1)
m6-336db1cd76254717eb50a8602b651fbf.tif:
m7-336db1cd76254717eb50a8602b651fbf.tif:
m8-336db1cd76254717eb50a8602b651fbf.tif:

```
### m1-3562055aecf63b573f8a18c4034a4a23.tif

### m2-3562055aecf63b573f8a18c4034a4a23.tif

  * Origin: {{{http://lexicon.ff.cuni.cz/tiff/goth_balg/b0350.tiff}}}

#### Notes

```
m1-3562055aecf63b573f8a18c4034a4a23.tif:
TIFF Directory at offset 0x10ae4 (68324)
  Image Width: 2653 Image Length: 3379
  Resolution: 118.12, 0
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Planar Configuration: single image plane
  DocumentName: gothic_tiffs//B350.tiff
m2-3562055aecf63b573f8a18c4034a4a23.tif:
TIFF Directory at offset 0x10ae4 (68324)
  Image Width: 2653 Image Length: 3379
  Resolution: 118.12, 0
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Orientation: row 0 top, col 0 lhs
  Rows/Strip: 3430
  Planar Configuration: single image plane
  DocumentName: gothic_ti·fs//B350.tiff
  Software: Z(#)ImageMagick 5.3.0 04/01/01 Q:16 http://www.imagemagick.kro

```
### 356a619433db27fb412ec6fef583eded.tif

  * Origin: {{{http://planning.babergh.gov.uk/doldp/4318_7.tif}}}

#### Notes

```
TIFF Directory at offset 0xe3ca4 (933028)
  Subfile Type: (0 = 0x0)
  Image Width: 2338 Image Length: 1656
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 3
  Rows/Strip: 1656
  Planar Configuration: single image plane
  SubIFD Offsets: 938146
  Software:  HATFILT Version 1.8  
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 8
  JpegInterchangeFormatLength: 932928
TIFF Directory at offset 0x1ab9e4 (1751524)
  Subfile Type: (0 = 0x0)
  Image Width: 2338 Image Length: 1656
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 3
  Rows/Strip: 1656
  Planar Configuration: single image plane
  SubIFD Offsets: 1756230
  Software:  HATFILT Version 1.8  
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 938308
  JpegInterchangeFormatLength: 813124

```
### 362323f81c0160afd677241cd5ce92e9.tif

  * Origin: {{{https://apps3.suffolkcoastal.gov.uk/planningonlinedocuments/77790_2.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1275 Image Length: 1755
  Resolution: 150, 150
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 1
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Page Number: 0-4
  Make: Hewlett-Packard
  Model: WIA-HP Scanjet 3800
  Software: Onstream Trapeze 6.16
  DateTime: 2007:11:19 10:17:09
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 486
  JpegInterchangeFormatLength: 282580
  JpegQTables: 518 583 583
  JpegDcTables: 671 697 697
  JpegAcTables: 719 822 822
  JpegProc: 1
TIFF Directory at offset 0x451ba (283066)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 970 Image Length: 1546
  Resolution: 150, 150
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 1
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Page Number: 1-4
  Make: Hewlett-Packard
  Model: WIA-HP Scanjet 3800
  Software: Onstream Trapeze 6.16
  DateTime: 2007:11:19 10:18:06
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 283544
  JpegInterchangeFormatLength: 383350
  JpegQTables: 283576 283641 283641
  JpegDcTables: 283729 283755 283755
  JpegAcTables: 283778 283884 283884
  JpegProc: 1
TIFF Directory at offset 0xa2d0e (666894)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1275 Image Length: 1755
  Resolution: 150, 150
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 1
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Page Number: 2-4
  Make: Hewlett-Packard
  Model: WIA-HP Scanjet 3800
  Software: Onstream Trapeze 6.16
  DateTime: 2007:11:19 10:18:40
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 667372
  JpegInterchangeFormatLength: 414823
  JpegQTables: 667404 667469 667469
  JpegDcTables: 667557 667583 667583
  JpegAcTables: 667605 667708 667708
  JpegProc: 1
TIFF Directory at offset 0x108354 (1082196)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1275 Image Length: 1755
  Resolution: 150, 150
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 1
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Page Number: 3-4
  Make: Hewlett-Packard
  Model: WIA-HP Scanjet 3800
  Software: Onstream Trapeze 6.16
  DateTime: 2007:11:19 10:19:05
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 1082674
  JpegInterchangeFormatLength: 307665
  JpegQTables: 1082706 1082771 1082771
  JpegDcTables: 1082859 1082884 1082884
  JpegAcTables: 1082905 1083009 1083009
  JpegProc: 1

```
### 3755b21390a93c1474aef88f4162de17.tif

  * Origin: {{{http://preferredlandscapetx.com/goliveimages/cert_arb.tif}}}

#### Notes

```
TIFF Directory at offset 0x41126 (266534)
  Subfile Type: (0 = 0x0)
  Image Width: 646 Image Length: 1126
  Resolution: 96, 96 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<unassoc-alpha>
  Samples/Pixel: 4
  Rows/Strip: 4
  Planar Configuration: single image plane
  Software: Adobe Photoshop 7.0
  DateTime: 2003:06:16 13:16:16
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 6532 bytes
  EXIFIFDOffset: 0x351304
  Predictor: none 1 (0x1)

```
### m1-3c6b71d657852e13d0b5dfc0906343f5.tif

  * Origin: {{{http://www.zunior.com/dropzone/thevioletarchers_bandphoto1.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Image Width: 1745 Image Length: 1309
  Resolution: 0, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 1
  Planar Configuration: single image plane
  Make: Canon
  Model: Canon EOSØ20D
  Software: QuickTime 7.1.3
  HostComputer: Mac OS X10.4.7
  EXIFIFDOffset: 0x2c8c
  ICC Profile: <present>, 560 bytes
TIFF Directory at offset 0x2c8c (11404)
  ExposureTime: 0.004000
  ExposureProgram: 86
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x32,0x30
  DateTimeOriginal: 2008:04:13 13:34:15
  DateTimeDigitized: 2008:04:13 13:34:15
  ApertureValue: 0.854529
  ExposureBiasValue: 0.000000
  MaxApertureValue: 2.968750
  MeteringMode: 6
  Flash: 9
  FocalLength: 18.000000

```
### m1-3ca2fd64c710a30edb60987e74d405cf.tif

### m2-3ca2fd64c710a30edb60987e74d405cf.tif

  * Origin: {{{http://files.dnr.state.mn.us/lakefind/data/lakemaps/c1185010.tif}}}

#### Notes

```
m1-3ca2fd64c710a30edb60987e74d405cf.tif:
m2-3ca2fd64c710a30edb60987e74d405cf.tif:

```
### 401d27e0565674c24a017588b8cd61d2.tif

  * Origin: {{{http://www.convisual.com/img/presse/handy/dwnld/austin_6630_300_hr.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 928 Image Length: 1772
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<unspecified>
  Samples/Pixel: 4
  Rows/Strip: 2
  Planar Configuration: single image plane
  Software: Adobe Photoshop Elements 2.0
  DateTime: 2005:01:24 11:05:43
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 15730 bytes
  EXIFIFDOffset: 0x25724c
  ICC Profile: <present>, 560 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x25724c (2454092)
  ExposureTime: 8.000000
  FNumber: 20.000000
  ExposureProgram: 1
  ISOSpeedRatings: 100
  DateTimeOriginal: 2004:04:26 13:55:57
  DateTimeDigitized: 2004:04:26 13:55:57
  ShutterSpeedValue: -3.000000
  ApertureValue: 8.625000
  ExposureBiasValue: 0.000000
  MeteringMode: 5
  Flash: 0
  FocalLength: 90.000000
  ColorSpace: 65535
  PixelXDimension: 928
  PixelYDimension: 1772
  FocalPlaneXResolution: 2886.363525
  FocalPlaneYResolution: 2885.805664
  FocalPlaneResolutionUnit: 2
  CustomRendered: 0
  ExposureMode: 1
  WhiteBalance: 0
  SceneCaptureType: 0

```
### m10-42c19f8e79e582bef107f372f18a074b.tif

### m11-42c19f8e79e582bef107f372f18a074b.tif

### m12-42c19f8e79e582bef107f372f18a074b.tif

### m13-42c19f8e79e582bef107f372f18a074b.tif

### m1-42c19f8e79e582bef107f372f18a074b.tif

### m14-42c19f8e79e582bef107f372f18a074b.tif

### m15-42c19f8e79e582bef107f372f18a074b.tif

### m16-42c19f8e79e582bef107f372f18a074b.tif

### m17-42c19f8e79e582bef107f372f18a074b.tif

### m18-42c19f8e79e582bef107f372f18a074b.tif

### m2-42c19f8e79e582bef107f372f18a074b.tif

### m3-42c19f8e79e582bef107f372f18a074b.tif

### m4-42c19f8e79e582bef107f372f18a074b.tif

### m5-42c19f8e79e582bef107f372f18a074b.tif

### m6-42c19f8e79e582bef107f372f18a074b.tif

### m7-42c19f8e79e582bef107f372f18a074b.tif

### m8-42c19f8e79e582bef107f372f18a074b.tif

### m9-42c19f8e79e582bef107f372f18a074b.tif

  * Origin: {{{http://csi.nfshost.com/wp-content/icon-3.tiff}}}

#### Notes

```
m10-42c19f8e79e582bef107f372f18a074b.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 17 Image Length: 45585
  Resolution: 72.009, 72.009 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 17
  Planar Configuration: single image plane
  Software: Adobe Pho®oshop CS3 Macintosh
  DateTime: 
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  EXIFIFDOffset: 0x739c
  ICC Profile: <present>, 4380 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x739c (29596)
  ColorSpace: 13311
  PixelXDimension: 17
  PixelYDimension: 17
m11-42c19f8e79e582bef107f372f18a074b.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 17 Image Length: 17
  Resolution: 72.009, 0
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 17
  Planar Configuration: single image plane
  DateTime: 2008:06:13 10:53:40
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 8920 bytes
  ICC Profile: <present>, 4380 bytes
  Predictor: horizontal differencing 2 (0x2)
m12-42c19f8e79e582bef107f372f18a074b.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 17 Image Length: 17
  Resolution: 72.009, 72.009 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 17
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS3 Macintosh
  DateTime: 2008:06:13 10:53:40
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 8920 bytes
  EXIFIFDOffset: 0x739c
  ICC Profile: <present>, 4380 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x739c (29596)
  ColorSpace: 65535
  PixelXDimension: 17
  PixelYDimension: 17
m13-42c19f8e79e582bef107f372f18a074b.tif:
m1-42c19f8e79e582bef107f372f18a074b.tif:
m14-42c19f8e79e582bef107f372f18a074b.tif:
m15-42c19f8e79e582bef107f372f18a074b.tif:
m16-42c19f8e79e582bef107f372f18a074b.tif:
m17-42c19f8e79e582bef107f372f18a074b.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 17 Image Length: 17
  Resolution: 72.009, 72.009
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 17
  Planar Configuration: single image plane
  DateTime: 2008:06:13 10:53:40
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 8920 bytes
  EXIFIFDOffset: 0x739c
  ICC Profile: <present>, 4380 bytes

```
### 434cb1e9680e3b4eda7f4dd430bcd2bf.tif

  * Origin: {{{http://vss01.narod.ru/files/6sem/sessiya_6sem.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2147 Image Length: 1027
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: palette color (RGB from colormap)
  Samples/Pixel: 1
  Rows/Strip: 3
  Planar Configuration: single image plane
  Color Map: (present)
  Make: CASIO
  Model: QV-4000  
  Software: Adobe Photoshop 7.0
  DateTime: 2004:05:25 11:58:16
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 5184 bytes
  EXIFIFDOffset: 0x58db8
  ICC Profile: <present>, 3144 bytes
  Predictor: none 1 (0x1)
TIFF Directory at offset 0x58db8 (363960)
  ExposureTime: 0.040000
  FNumber: 2.300000
  ExposureProgram: 1
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2004:05:25 08:16:46
  DateTimeDigitized: 2004:05:25 08:16:46
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 4.012406
  ExposureBiasValue: 0.000000
  MaxApertureValue: 2.000000
  MeteringMode: 5
  Flash: 1
  FocalLength: 11.760000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 1
  PixelXDimension: 2147
  PixelYDimension: 1027

```
### m1-487f40372de5a8b6c848ba2569848492.tif

  * Origin: {{{http://lexicon.ff.cuni.cz/tiff/oswed_noreen/b0456.tiff}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1235 Image Length: 2128
  Resolution: 296.365, 0.352634
  Compression Scheme: LZW
  Photometric Interpretation: 21248 (0x5300)
  Samples/Pixel: 1
  Rows/Strip: 52
  Planar Configuration: single image plane
  DateTime: 2003:10:06 15:ƒ4:52
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 16492 bytes
  EXIFIFDOffset: 0x1e190

```
### 48af30b09e42ec73f206ce1ac09a424b.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x1bffc (114684)
  Image Width: 333 Image Length: 225
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 16
  Sample Format: signed integer
  Compression Scheme: SGILog
  Photometric Interpretation: CIE Log2(L) (u',v')
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 8
  Planar Configuration: single image plane
  Sample to Nits conversion factor: 1.7900e+02

```
### m1-4a7d8e5153957beadcd49c6f540aab78.tif

  * Origin: {{{http://www.angelfire.com/ak3/ahti3/images/aita.tif}}}

#### Notes

```

```
### 54743a2a36ef90c7ed8bb5da8b6ebaf4.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x34226 (213542)
  Image Width: 512 Image Length: 384
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 5
  Planar Configuration: single image plane

```
### m1-5512ff2fc91566c07c8c8d3fd352a731.tif

  * Origin: {{{http://www.infodez.ru/production/_oborud/destruktor_etna-497/destruktor_etna-ru-020919.tif}}}

#### Notes

```

```
### 551adc8ce6c3c9cc59040903b0428f47.tif

  * Origin: {{{http://n2.nabble.com/attachment/2048472/0/slope_rgb_dfl_tls.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Image Width: 190 Image Length: 143
  Tile Width: 256 Tile Length: 256
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Sample Format: unsigned integer
  Compression Scheme: AdobeDeflate
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Planar Configuration: single image plane
  DocumentName: /home/shoofi/slope.tif
  Predictor: none 1 (0x1)

```
### 5dd2583cd54384e56a769f04ea05c999.tif

  * Origin: {{{http://gerb.murman.ru/tif/region_2004.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 600 Image Length: 802
  Resolution: 118.11, 118.11 pixels/cm
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 109
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS2 Windows
  DateTime: 2006:06:15 20:50:55
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 8084 bytes
  EXIFIFDOffset: 0x34c98
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x34c98 (216216)
  ColorSpace: 65535
  PixelXDimension: 600
  PixelYDimension: 802

```
### m1-62804e47400d6a0fd233c32ea8db4e48.tif

  * Origin: {{{http://gfx.ip-sprachreisen.de/presse/exmouth_beach_hi_res.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1000 Image Length: 667
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 16
  Compression Scheme: None
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 667
  Planar Configuration: single image plane
  SubIFD Offsets: 5906976
  Make: Canon
  Model: Canon EOS 20D
  Software: Adobe Photoshop 7.0
  Dot Range: 0-65535
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 5050 bytes
  EXIFIFDOffset: 0x5a1f70
  ICC Profile: <present>, 557164 bytes
TIFF Directory at offset 0x5a1f70 (5906288)
  ExposureTime: 0.001250
  FNumber: 6.300000
  ExposureProgram: 3
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x32,0x31
  DateTimeOriginal: 2006:07:09 16:39:54
  DateTimeDigitized: 2006:07:09 16:39:54
  ComponentsConfiguration: 0x0,0x0,0x0,0x0
  ShutterSpeedValue: 9.643860
  ApertureValue: 5.310699
  ExposureBiasValue: 0.000000
  MeteringMode: 5
  Flash: 16
  FocalLength: 55.000000
  FlashpixVersion: 0x30,0x31,0x30,0xd8
  ColorSpace: 65535
  PixelXDimension: 1000
  PixelYDimension: 667
  FocalPlaneXResolution: 3959.322021
  FocalPlaneYResolution: 3959.322021
  FocalPlaneResolutionUnit: 2
  CustomRendered: 0
  ExposureMode: 0
  WhiteBalance: 0
  SceneCaptureType: 0

```
### m1-63c8b14ea08a18c884d05a3431716047.tif

### m2-63c8b14ea08a18c884d05a3431716047.tif

### m3-63c8b14ea08a18c884d05a3431716047.tif

### m4-63c8b14ea08a18c884d05a3431716047.tif

### m5-63c8b14ea08a18c884d05a3431716047.tif

### m6-63c8b14ea08a18c884d05a3431716047.tif

  * Origin: {{{http://lis.ly.gov.tw/npl/commun/58/3.tif}}}

#### Notes

```
m1-63c8b14ea08a18c884d05a3431716047.tif:
m2-63c8b14ea08a18c884d05a3431716047.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1433 Image Length: 2023
  Resolution: 200, 200
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 2023
  Planar Configuration: single image plane
  DateTime: 2005.09.15 16:28:54
m3-63c8b14ea08a18c884d05a3431716047.tif:
m4-63c8b14ea08a18c884d05a3431716047.tif:
m5-63c8b14ea08a18c884d05a3431716047.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1433 Image Length: 2023
  Resolution: 200, 200
  Bits/Sample: 1
  Compression Scheme: None
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 2023
  Planar Configuration: single image plane
  Software: Fu≤i Xerox Co., Ltd. Raster S»pport Toolkit Version 2.3
  DateTime: 2005.09.15 16:28:54
m6-63c8b14ea08a18c884d05a3431716047.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1433 Image Length: 2023
  Resolution: 200, 200
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 2023
  Planar Configuration: single image plane
  Software: Fu≤i Xerox Co., Ltd. Raster S»pport Toolkit Version 2.3
  DateTime: 2005.09.15 16:28:54

```
### 6453732434a8a2358a3c895d962bdce2.tif

  * Origin: {{{http://www.sparetimelabs.com/test-out.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 200 Image Length: 200
  Tile Width: 128 Tile Length: 128
  Resolution: 20, 20 pixels/cm
  Bits/Sample: 8
  Compression Scheme: PackBits
  Photometric Interpretation: RGB color
  Extra Samples: 1<assoc-alpha>
  Samples/Pixel: 4
  Planar Configuration: single image plane
  Software: Adobe Photoshop 7.0
  DateTime: 2005:01:22 08:13:44
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 3888 bytes
  EXIFIFDOffset: 0x22c8
TIFF Directory at offset 0x22c8 (8904)
  ColorSpace: 65535
  PixelXDimension: 200
  PixelYDimension: 200

```
### m1-68bc8a1966db7a1da2d3b5946c00d1af.tif

  * Origin: {{{http://www.nhicb.gov.tw/nhicbj00/tif/0000000319.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Image Width: 3306 Image Length: 2368
  Resolution: 200, 0.0052082 pixels/inch
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 76
  Planar Configuration: single image plane
  Ink Set: CMYK
  Software: Oi/GFS, writer v00.06.02
  Group 4 Options: (0 = 0x0)

```
### 6cd02db6f3688efdd705c28ffcb9a3d3.tif

  * Origin: {{{http://www.rootsweb.com/~irlcav/moy.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 7465 Image Length: 5536
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: (infinite)
  Planar Configuration: single image plane
  Page Number: 1-1
  Make: Oce 
  Model: 9400  
  Software: Imagenation VME
  Group 4 Options: (0 = 0x0)

```
### 7324fcaff3aad96f27899da51c1bb5d9.tif

  * Origin: {{{http://www.luotain.uku.fi/~kraka/uudet_sivut/data/pressi/kraka_pressi02.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 4064 Image Length: 2487
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: AdobeDeflate
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 86
  Planar Configuration: single image plane
  Make: Canon
  Model: Canon EOS-1DS
  Software: Adobe Photoshop CS Windows
  DateTime: 2004:06:13 17:44:48
  Artist: Studio Mantyniemi
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 32 bytes
  Photoshop Data: <present>, 126558 bytes
  EXIFIFDOffset: 0xe73c6c
  ICC Profile: <present>, 560 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0xe73c6c (15154284)
  ExposureTime: 0.016667
  FNumber: 18.000000
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x32,0x30
  DateTimeOriginal: 2003:11:25 16:05:53
  DateTimeDigitized: 2003:11:25 16:05:53
  ShutterSpeedValue: 6.000000
  ApertureValue: 8.375000
  ExposureBiasValue: 0.000000
  FocalLength: 63.000000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 65535
  PixelXDimension: 4064
  PixelYDimension: 2487
  FocalPlaneXResolution: 2886.363525
  FocalPlaneYResolution: 2885.805664
  FocalPlaneResolutionUnit: 2
  CustomRendered: 0
  ExposureMode: 1
  WhiteBalance: 1
  SceneCaptureType: 0

```
### m10-76c43508fc007bcf5902b6a28e8055a5.tif

### m11-76c43508fc007bcf5902b6a28e8055a5.tif

### m12-76c43508fc007bcf5902b6a28e8055a5.tif

### m1-76c43508fc007bcf5902b6a28e8055a5.tif

### m2-76c43508fc007bcf5902b6a28e8055a5.tif

### m3-76c43508fc007bcf5902b6a28e8055a5.tif

### m4-76c43508fc007bcf5902b6a28e8055a5.tif

### m5-76c43508fc007bcf5902b6a28e8055a5.tif

### m6-76c43508fc007bcf5902b6a28e8055a5.tif

### m7-76c43508fc007bcf5902b6a28e8055a5.tif

### m8-76c43508fc007bcf5902b6a28e8055a5.tif

### m9-76c43508fc007bcf5902b6a28e8055a5.tif

  * Origin: {{{http://www.swr.de/presseservice/logos/swr2/-/id=228486/property=download/nid=4084/zpjqve/index.tif}}}

#### Notes

```
m10-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelYDimension: 1313
m11-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelYDimension: 1313
m12-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 79
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe PhoosÃop 7.0
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
m1-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: esc="CR"?>
<x:xapmeH
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
m2-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 0, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelYDimension: 1313
m3-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 1772 Image Length: 1313
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc7280
  ICC Profile: <present>, 557164 bytes
m4-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8224
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe PhotosÃop 7.0
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
m5-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: transparency mask (228 = 0xe4)
  Image Width: 1772 Image Length: 1313
  Resolution: 706.323, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe PhotosÃop 7.0
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
m6-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1772 Image Length: 1313
  Resolution: 300, 0.962106 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  Software: Adobe Photoshop 7.0
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
  Predictor: 60162 (0xeb02)
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelXDimension: 671090412
  PixelYDimension: 1313
m7-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1772 Image Length: 1313
  Resolution: 300, 300
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
  Predictor: 60162 (0xeb02)
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelXDimension: 1772
  PixelYDimension: 1313
m8-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 1772 Image Length: 1313
  Resolution: 300, 0
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshop 7.0
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
  ICC Profile: <present>, 557164 bytes
  Predictor: 60315 (0xeb9b)
TIFF Directory at offset 0xc8e80 (822912)
  ColorSpace: 65535
  PixelXDimension: 1772
  PixelYDimension: 1313
m9-76c43508fc007bcf5902b6a28e8055a5.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (14080 = 0x3700)
  Image Width: 1772 Image Length: 1313
  Resolution: 300, 0
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 1
  Planar Configuration: single image plane
  ImageDescription: 
  Software: Adobe Photoshor 7.0
  Dot Range: 0-255
  Photoshop Data: <present>, 5840 bytes
  EXIFIFDOffset: 0xc8e80
  Predictor: 60162 (0xeb02)
TIFF Directory at offset 0xc8e80 (822912)
  PixelYDimension: 1313

```
### m1-76d5d8fd02d58b774f2bae6f7b763e3e.tif

### m2-76d5d8fd02d58b774f2bae6f7b763e3e.tif

### m3-76d5d8fd02d58b774f2bae6f7b763e3e.tif

  * Origin: {{{Unknown}}}

#### Notes

```

```
### m1-79818c280a08c94bf7fd2a54b1e2567d.tif

  * Origin: {{{http://www.geocities.com/jwhicks53705/cem_map.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2500 Image Length: 3225
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 1
  Compression Scheme: None
  Photometric Interpretation: min-is-black
  Samples/Pixel: 1
  Rows/Strip: 26
  Planar Configuration: single image plane

```
### m1-8110934bb3b18d0e87ccc1ddfc5f0107.tif

  * Origin: {{{ftp://ftp.cordis.europa.eu/pub/paxis/docs/open_space_conference.tif}}}

#### Notes

```
TIFF Directory at offset 0x3b94 (15252)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0xb05a (45146)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Sample Format: void
  Compression Scheme: None
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
TIFF Directory at offset 0x251c6 (152006)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x3442c (214060)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x4cf20 (315168)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x5edea (388586)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x79810 (497680)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x8e01e (581662)
  Subfile Type: (0 = 0x0)
  Image Width: 3307 Image Length: 4704
  Resolution: 400, 400 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 4704
  Planar Configuration: single image plane
  Group 4 Options: (0 = 0x0)

```
### 84399cc32c29ac0cf33b96a0f654f379.tif

  * Origin: {{{http://larsdoornbos.com/zoom.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 3300 Image Length: 3508
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 1
  YCbCr Positioning: cosited
  Samples/Pixel: 3
  Rows/Strip: 6
  Planar Configuration: single image plane
  Software: Adobe Photoshop 7.0
  DateTime: 2006:06:08 14:55:36
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 15828 bytes
  EXIFIFDOffset: 0xaf3748
  JPEG Tables: (558 bytes)
TIFF Directory at offset 0xaf3748 (11482952)
  ColorSpace: 65535
  PixelXDimension: 3300
  PixelYDimension: 3508

```
### m1-84da94dc7e5469f7849b0a7efdff5462.tif

  * Origin: {{{http://talks.mark-itt.ru/forums/icons/forum_pictures/000556/556923.tif}}}

#### Notes

```
TIFF Directory at offset 0x372e32 (3616306)
  Subfile Type: (0 = 0x0)
  Image Width: 1754 Image Length: 2481
  Resolution: 150, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 2
  Planar Configuration: single image plane
  ImageDescription: image description
  Predictor: horizontal differencing 2 (0x2)

```
### 89b5888641d5910e92bf451b5e639ad0.tif

  * Origin: {{{http://4praise.com/cgi-bin/files/sm/380.tif}}}

#### Notes

```
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 766 Image Length: 991
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 8
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
  JpegInterchangeFormat: 444
  JpegInterchangeFormatLength: 601
  JpegQTables: 8665 8734 8734
  JpegDcTables: 8822 9038 9038
  JpegAcTables: 8855 9071 9071
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x17a8c (96908)
  Subfile Type: (0 = 0x0)
  Image Width: 766 Image Length: 991
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 1
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 8
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
  JpegInterchangeFormat: 97280
  JpegInterchangeFormatLength: 601
  JpegQTables: 169533 169602 169602
  JpegDcTables: 169690 169906 169906
  JpegAcTables: 169723 169939 169939
  JpegProc: 1
  JpegRestartInterval: 0

```
### 8d8582b004aa2560f5bccffbccf4f3d6.tif

  * Origin: {{{http://www.biesse.it/dati/files/246_508_master_30_worktable.tif}}}

#### Notes

```
TIFF Directory at offset 0xfe626 (1041958)
  Subfile Type: (0 = 0x0)
  Image Width: 680 Image Length: 510
  Resolution: 72, 72 (unitless)
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Samples/Pixel: 3
  Rows/Strip: 510
  Planar Configuration: single image plane
  Make: Hasselblad/Imacon
  Model: Ixpress 528C - Hasselblad ELD
  RichTIFFIPTC Data: <present>, 92 bytes
  Photoshop Data: <present>, 104 bytes
  EXIFIFDOffset: 0x5c8
  ICC Profile: <present>, 1080 bytes
TIFF Directory at offset 0x5c8 (1480)
  ExposureTime: 0.016667
  ISOSpeedRatings: 50
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2006:09:12 21:04:57
  DateTimeDigitized: 2006:09:12 21:04:57
  ShutterSpeedValue: 5.906890

```
### m1-93456679a773921d30efafd08f3ad542.tif

  * Origin: {{{http://www.archive.org/download/usgs_drg_wi_45091_a6/o45091a6.tif}}}

#### Notes

```
TIFF Directory at offset 0x450eb0 (4525744)
  Subfile Type: (0 = 0x0)
  Image Width: 4772 Image Length: 6776
  Resolution: 250, 250 pixels/inch
  Bits/Sample: 8
  Compression Scheme: PackBits
  Photometric Interpretation: palette color (RGB from colormap)
  Samples/Pixel: 1
  Rows/Strip: 1
  Planar Configuration: single image plane
  Color Map: (present)
  ImageDescription: @
  DateTime: 1996:11:19 13:58:06

```
### m1-96292a1bd64fec83bb6cdd2480a755b6.tif

  * Origin: {{{http://clubvudu.googlegroups.com/web/vudu-embassy-a3.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1169 Image Length: 1654
  Resolution: 0, 100 pixels/inch
  Bits/Sample: 8
  Compression Scheme: AdobeDeflate
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 896
  Planar Configuration: separate image planes
  Software: Adobe Photoshop CS3 Macintosh
  DateTime: 2007:09:26 16:19:29
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 22290 bytes
  EXIFIFDOffset: 0x2e8018
  ICC Profile: <present>, 3144 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x2e8018 (3047448)
  ColorSpace: 1
  PixelYDimension: 1654

```
### m1-9a47770b40347f842caed33f5baa41df.tif

  * Origin: {{{http://www.archive.org/download/usgs_drg_tx_28097_e1/o28097e1.tif}}}

#### Notes

```

```
### 9b286add70871bbbef1601997b429344.tif

  * Origin: {{{http://www.jyjs.gov.cn/sylj/fgk/20070629a.tif}}}

#### Notes

```
TIFF Directory at offset 0x3012 (12306)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1646 Image Length: 2332
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2332
  Planar Configuration: single image plane
  DocumentName: DN0PUnknown serial  1179132224         811000.----!--
  Make: Kodak
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: 2007:05:14 16:44:35
  Artist: IRIS 2001          
TIFF Directory at offset 0x9d0c (40204)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1653 Image Length: 2333
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2333
  Planar Configuration: single image plane
  DocumentName: DN0PUnknown serial  1179132224         900000.----!--
  Make: Kodak
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: 2007:05:14 16:44:37
  Artist: IRIS 2001          
TIFF Directory at offset 0x100ce (65742)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1653 Image Length: 2329
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2329
  Planar Configuration: single image plane
  DocumentName: DN0PUnknown serial  1179132224         911000.----!--
  Make: Kodak
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: 2007:05:14 16:44:38
  Artist: IRIS 2001          
TIFF Directory at offset 0x57cbc (359612)
  Subfile Type: (0 = 0x0)
  Image Width: 1641 Image Length: 2317
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 3
  Rows/Strip: 2317
  Planar Configuration: single image plane
  SubIFD Offsets: 365700
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: 2007:05:14 16:44:40
  Artist: IRIS 2001          
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JpegInterchangeFormat: 66024
  JpegInterchangeFormatLength: 293443

```
### 9bd49db0707bb5d7ddeca56b1de28ab8.tif

  * Origin: {{{http://www.cestisticalatina.it/public//2009/01/colombo.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1972 Image Length: 2000
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 177
  Planar Configuration: single image plane
  Make: NIKON CORPORATION
  Model: NIKON D200
  Software: Adobe Photoshop CS3 Macintosh
  DateTime: 2009:01:29 14:29:52
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 12394 bytes
  EXIFIFDOffset: 0x2ab44
  ICC Profile: <present>, 560 bytes

```
### a516905c06cbc05e8adac7b0b7e4f514.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x32fee (208878)
  Image Width: 512 Image Length: 384 Image Depth: 1
  Tile Width: 128 Tile Length: 128 Tile Depth: 1
  Bits/Sample: 8
  Sample Format: void
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 128
  Min Sample Value: 0
  Max Sample Value: 255
  Planar Configuration: single image plane

```
### b05937c07e0f3ce1bfd2c8c71b0220ec.tif

  * Origin: {{{http://www.haui.edu.vn/tailieu/duhoc/toana2.tif}}}

#### Notes

```
TIFF Directory at offset 0x981d2 (623058)
  Subfile Type: (0 = 0x0)
  Image Width: 1205 Image Length: 1719
  Tile Width: 1216 Tile Length: 1728
  Resolution: 150, 150 pixels/inch
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 3
  Planar Configuration: single image plane
  SubIFD Offsets: 633154
  Model: EPSON Perfection 2480/2580
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2007:09:10 15:14:12
  Artist: QTKD
  JpegInterchangeFormat: 8
  JpegInterchangeFormatLength: 617390
  JpegProc: 1
TIFF Directory at offset 0x117ffa (1146874)
  Subfile Type: (0 = 0x0)
  Image Width: 1112 Image Length: 1664
  Tile Width: 1120 Tile Length: 1664
  Resolution: 150, 150 pixels/inch
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: min-is-black
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 1
  Planar Configuration: single image plane
  SubIFD Offsets: 1155912
  Model: EPSON Perfection 2480/2580
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2007:09:10 15:15:06
  Artist: QTKD
  JpegInterchangeFormat: 633316
  JpegInterchangeFormatLength: 511934
  JpegProc: 1
TIFF Directory at offset 0x123328 (1192744)
  Subfile Type: (0 = 0x0)
  Image Width: 2130 Image Length: 3341
  Resolution: 300, 300 pixels/inch
  Position: 0, 0
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 240
  Planar Configuration: single image plane
  SubIFD Offsets: 1200156
  Model: EPSON Perfection 2480/2580
  Software: Microsoft Office Document Scanning  1.03.2349.01 
  DateTime: 2007:09:10 15:15:48
  Artist: QTKD

```
### m1-b0d36ed02fc2624ac79d3144e8b1bda2.tif

### m2-b0d36ed02fc2624ac79d3144e8b1bda2.tif

### m3-b0d36ed02fc2624ac79d3144e8b1bda2.tif

  * Origin: {{{http://www.gsfc.nasa.gov/gsfc/spacesci/pictures/20020509imagessu/mag3.tif}}}

#### Notes

```
m1-b0d36ed02fc2624ac79d3144e8b1bda2.tif:
TIFF Directory at offset 0x767fe (485374)
  Image Width: 1024 Image Length: 768
  Resolution: 1, 0.99975 (unitless)
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Samples/Pixel: 4
  Planar Configuration: single image plane
  ImageDescription: Composer: Untitled, frame 0
  Software: CoÚposer
  DateTime: Tue May  7 21:48:30 2002
  Artist: maya
  HostComputer: thor
m2-b0d36ed02fc2624ac79d3144e8b1bda2.tif:
TIFF Directory at offset 0x767fe (485374)
  Image Width: 1024 Image Length: 768
  Resolution: 2, 0 (unitless)
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Samples/Pixel: 4
  Planar Configuration: single image plane
  Transfer Function: (present)
  Software: Composer
  DateTime: Tue May  7 21:48:30 2002
  Artist: maya
  HostComputer: thor
m3-b0d36ed02fc2624ac79d3144e8b1bda2.tif:

```
### b1247c37897d354610a07ddfe17eb669.tif

  * Origin: {{{http://elyon1.court.gov.il/heb/tovanot_yezugiyot/154.tif}}}

#### Notes

```
TIFF Directory at offset 0x98d4 (39124)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2311
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2311
  Planar Configuration: single image plane
  Page Number: 0-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:39:13
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x13e52 (81490)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 1-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:39:33
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x1ebd8 (125912)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2307
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2307
  Planar Configuration: single image plane
  Page Number: 2-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:39:54
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x29844 (170052)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 3-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:40:15
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x34908 (215304)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2307
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2307
  Planar Configuration: single image plane
  Page Number: 4-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:40:36
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x3fdaa (261546)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 5-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:40:58
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x455a8 (284072)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2306
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2306
  Planar Configuration: single image plane
  Page Number: 6-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:41:10
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x4e568 (320872)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 7-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:41:28
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x591f0 (365040)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2306
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2306
  Planar Configuration: single image plane
  Page Number: 8-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:41:49
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x62f3a (405306)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2425
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2425
  Planar Configuration: single image plane
  Page Number: 9-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:42:08
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 10
  Consecutive Bad Fax Lines: 8
TIFF Directory at offset 0x6d612 (448018)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 10-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:42:28
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x77e48 (491080)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2306
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2306
  Planar Configuration: single image plane
  Page Number: 11-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:42:48
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x7d0ce (512206)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 12-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:43:00
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x8747e (554110)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2306
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2306
  Planar Configuration: single image plane
  Page Number: 13-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:43:20
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x8bc82 (572546)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 14-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:43:31
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0x9d140 (643392)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2307
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2307
  Planar Configuration: single image plane
  Page Number: 15-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:44:04
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xa3fd0 (671696)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 16-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:44:19
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xa9cb2 (695474)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2307
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2307
  Planar Configuration: single image plane
  Page Number: 17-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:44:31
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xb0616 (722454)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2305
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2305
  Planar Configuration: single image plane
  Page Number: 18-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:44:45
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 5
  Consecutive Bad Fax Lines: 3
TIFF Directory at offset 0xbad04 (765188)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2306
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2306
  Planar Configuration: single image plane
  Page Number: 19-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:45:05
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xc5da2 (810402)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 20-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:45:26
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xd3554 (865620)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2308
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2308
  Planar Configuration: single image plane
  Page Number: 21-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:45:51
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xe1fb2 (925618)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2310
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2310
  Planar Configuration: single image plane
  Page Number: 22-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:46:19
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2
TIFF Directory at offset 0xe5c50 (941136)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 2305
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2305
  Planar Configuration: single image plane
  Page Number: 23-0
  ImageDescription: 
  Software: Dialogic - Cheetah Dm3Fax version 1.00
  DateTime: 2008:02:13 14:46:28
  Group 3 Options: (0 = 0x0)
  Fax Data: receiver regenerated (1 = 0x1)
  Bad Fax Lines: 2
  Consecutive Bad Fax Lines: 2

```
### m1-b127f0fb89daedea07abb50b9db2dfd9.tif

  * Origin: {{{http://lexicon.ff.cuni.cz/tiff/pgmc_torp/b0045.tiff}}}

#### Notes

```

```
### m1-b1ab6f4b81e9b8020a90c8f2c9bcfedb.tif

### m2-b1ab6f4b81e9b8020a90c8f2c9bcfedb.tif

  * Origin: {{{http://mvhwrestle.net/pipermail/wrestlers_mvhwrestle.net/attachments/20080302/657a88ee/attachment-0001.tiff}}}

#### Notes

```
m1-b1ab6f4b81e9b8020a90c8f2c9bcfedb.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 1078
  Resolution: 204, 0 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Samples/Pixel: 1
  Rows/Strip: 1078
  Planar Configuration: single image plane
  Page Number: 1-0
  ImageDescription:         15102780734                 K7FAX  Thu Feb 28 09:42:34 2008

  Group 3 Options: (0 = 0x0)
  Fax Data: (140 = 0x8c)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0
m2-b1ab6f4b81e9b8020a90c8f2c9bcfedb.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 1078
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Samples/Pixel: 1
  Rows/Strip: 1078
  Planar Configuration: single image plane
  Page Number: 1-0
  ImageDescription:          151_2770734             e   K7FAX  Thu Feb 28 09:42:34 2008

  Group 3 Options: (0 = 0x0)
  Fax Data: clean (0 = 0x0)
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0xef0b (61195)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 1077
  Resolution: 64, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Samples/Pixel: 1
  Rows/Strip: 1077
  Planar Configuration: single image plane
  Page Number: 1-0
  ImageDescription:          15102780734                 K7FAX  Thu Feb 28 09:43:12 2008

  Group 3 Options: (0 = 0x0)
  Bad Fax Lines: 0
  Consecutive Bad Fax Lines: 0

```
### b52a2fceb34f9b31cb417379cf8c02ba.tif

  * Origin: {{{http://www.brixen.tirol.gv.at/gelbeseite/logo/50074821.tif}}}

#### Notes

```
TIFF Directory at offset 0x18ea (6378)
  Subfile Type: (0 = 0x0)
  Image Width: 54 Image Length: 50
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  YCbCr Positioning: 0 (0x0)
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 50
  Planar Configuration: single image plane
  Page Number: 0-0
  Software: Adobe Photoshop CS Macintosh
  DateTime: 2006:01:05 12:54:59
  White Point: 0-0
  PrimaryChromaticities: 0.000000,0.000000,0.000000,0.000000,0.000000,0.000000
  YCbCrCoefficients: 0.000000,0.000000,0.000000
  Reference Black/White:
     0:     0     0
     1:     0     0
     2:     0     0
  XMLPacket (XMP Metadata): Present
  EXIFIFDOffset: 0x142
  Predictor: horizontal differencing 2 (0x2)

```
### b9bc00e0fb28f2a525c0acfe78251eda.tif

  * Origin: {{{http://vas.lex.bg/files/faxview.tif}}}

#### Notes

```
TIFF Directory at offset 0x8b6c (35692)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1163
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Samples/Pixel: 1
  Rows/Strip: 1163
  Planar Configuration: single image plane
  Page Number: 0-0
  Software: Windows NT Fax Server
  Fax Data: clean (0 = 0x0)
  Consecutive Bad Fax Lines: 0
TIFF Directory at offset 0xc1fa (49658)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1728 Image Length: 1169
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: lsb-to-msb
  Samples/Pixel: 1
  Rows/Strip: 1169
  Planar Configuration: single image plane
  Page Number: 1-0
  Software: Windows NT Fax Server
  Fax Data: clean (0 = 0x0)
  Consecutive Bad Fax Lines: 0

```
### m1-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

### m2-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

### m3-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

### m4-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

### m5-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

### m6-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif

  * Origin: {{{http://www.mof.go.th/rule/picture/590_doc.tif}}}

#### Notes

```
m1-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 1950 Image Length: 2454
  Resolution: 300, 0 pixels/inch
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Planar Configuration: single image plane
TIFF Directory at offset 0xba84 (47748)
  Subfile Type: (0 = 0x0)
  Image Width: 966 Image Length: 1497
  Bits/Sample: 8
  Compression Scheme: LZW
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 38176
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
m2-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 1950 Image Length: 2454
  Resolution: 300, 0 pixels/inch
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  Photometric Interpretation: min-is-white
  Samples/Pixel: 1
  Rows/Strip: 130
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
m3-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Image Width: 1950 Image Length: 2454
  Resolution: 300, 0
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Planar Configuration: single image plane
TIFF Directory at offset 0xba84 (47748)
  Image Width: 966 Image Length: 1497
  Resolution: 1.04084, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 32
  Planar Configuration: single image plane
  Ink Set: CMYK
  Software: Oi/GFSÍ writer v00.06.01P&
m4-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 1950 Image Length: 2454
  Resolution: 300, 0 pixels/inch
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 130
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
TIFF Directory at offset 0xba84 (47748)
  Image Width: 966 Image Length: 1497
  Resolution: 150, 150 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 32
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
m5-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 1950 Image Length: 2454
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 130
  SMax Sample Value: 300
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P
m6-bfa1e2fb1d67bcd9d902a0dbf5badb70.tif:
TIFF Directory at offset 0x48 (72)
  Subfile Type: (0 = 0x0)
  Image Width: 1950 Image Length: 2454
  Resolution: 300, 0 pixels/inch
  Bits/Sample: 26
  Compression Scheme: CCITT RLE
  Photometric Interpretation: min-is-white
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 130
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.01P

```
### c0d253443d8d4241035fff993ea0581b.tif

  * Origin: {{{http://www.runwaymiami.com/wp-content/uploads/2008/07/tibi.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 600 Image Length: 1400
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 1
  YCbCr Positioning: cosited
  Samples/Pixel: 3
  Rows/Strip: 36
  Planar Configuration: single image plane
  Make: Canon
  Model: Canon EOS 5D
  Software: Adobe Photoshop 7.0
  DateTime: 2008:07:16 16:27:13
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 4142 bytes
  EXIFIFDOffset: 0x41eec
  ICC Profile: <present>, 3144 bytes
  JPEG Tables: (558 bytes)
TIFF Directory at offset 0x41eec (270060)
  ExposureTime: 0.010000
  FNumber: 13.000000
  ExposureProgram: 1
  ISOSpeedRatings: 400
  ExifVersion: 0x30,0x32,0x32,0x31
  DateTimeOriginal: 2008:07:14 23:12:10
  DateTimeDigitized: 2008:07:14 23:12:10
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  ShutterSpeedValue: 6.625000
  ApertureValue: 7.375000
  ExposureBiasValue: 0.000000
  MeteringMode: 5
  Flash: 16
  FocalLength: 38.000000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 1
  PixelXDimension: 600
  PixelYDimension: 1400
  FocalPlaneXResolution: 3086.925781
  FocalPlaneYResolution: 3091.295166
  FocalPlaneResolutionUnit: 2
  CustomRendered: 0
  ExposureMode: 1
  WhiteBalance: 0
  SceneCaptureType: 0

```
### c16f4894de3142b98e8f3d8fc6b3d23e.tif

  * Origin: {{{http://img1.xooimage.com/files/c/1/6/a-lire-a38a7a.tiff}}}

#### Notes

```
TIFF Directory at offset 0x7562 (30050)
  Image Width: 50 Image Length: 50
  Resolution: 1000, 1000 pixels/inch
  Bits/Sample: 32
  Sample Format: IEEE floating point
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 218
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS4 Macintosh
  DateTime: 2009:01:18 18:41:23
  EXIFIFDOffset: 0x8
  ICC Profile: <present>, 600 bytes
TIFF Directory at offset 0x8 (8)
  ColorSpace: 65535
  PixelXDimension: 50
  PixelYDimension: 50

```
### ccd82bb72407d0ca03cac50eb42faf47.tif

  * Origin: {{{http://www.lizparrypr.co.uk/wp-content/uploads/2008/08/new-adobe-photoshop-image.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 347 Image Length: 80
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 80
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS Windows
  DateTime: 2008:08:06 15:31:22
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 3850 bytes
  EXIFIFDOffset: 0x42b0
  ICC Profile: <present>, 3144 bytes
  JPEG Tables: (459 bytes)
TIFF Directory at offset 0x42b0 (17072)
  ColorSpace: 1
  PixelXDimension: 347
  PixelYDimension: 80

```
### ce50e53224a3b62bb821bc294bf6a588.tif

  * Origin: {{{http://xce.xanga.com/50e8516b463a8230354080/b181528215.tif}}}

#### Notes

```
TIFF Directory at offset 0x5c6fe (378622)
  Subfile Type: (0 = 0x0)
  Image Width: 564 Image Length: 423
  Resolution: 96, 96 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  YCbCr Positioning: cosited
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 7
  Planar Configuration: single image plane
  ImageDescription: OLYMPUS DIGITAL CAMERA         
  Make: OLYMPUS IMAGING CORP.
  Model: FE190/X750
  Software: Version 1.0
  DateTime: 2009:01:19 22:56:26
  Predictor: none 1 (0x1)

```
### m1-d0f86ab189cbe900ec389ca6d7464713.tif

### m2-d0f86ab189cbe900ec389ca6d7464713.tif

### m3-d0f86ab189cbe900ec389ca6d7464713.tif

### m4-d0f86ab189cbe900ec389ca6d7464713.tif

### m5-d0f86ab189cbe900ec389ca6d7464713.tif

  * Origin: {{{http://www.earsandeyes.com/downloads/logo_eae.tif}}}

#### Notes

```
m1-d0f86ab189cbe900ec389ca6d7464713.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2717 Image Length: 385
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 96
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS2 Macintosh
  DateTime: 2007:12:02 14:43:35
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 11226 bytes
  EXIFIFDOffset: 0xb5300
  ICC Profile: <present>, 557168 bytes
  JPEG Tables: (285 bytes)
TIFF Directory at offset 0xb5300 (742144)
  ColorSpace: 65535
  PixelXDimension: 2717
  PixelYDimension: 385
m2-d0f86ab189cbe900ec389ca6d7464713.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 1949 Image Length: 385
  Resolution: inf, 0 pixels/inch
  Compression Scheme: JPEG
  Photometric Interpretation: separated
  Samples/Pixel: 34564
  Rows/Strip: 96
  Planar Configuration: single image plane
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 11226 bytes
  EXIFIFDOffset: 0xb5300
  ICC Profile: <present>, 557168 bytes
m3-d0f86ab189cbe900ec389ca6d7464713.tif:
m4-d0f86ab189cbe900ec389ca6d7464713.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2717 Image Length: 385
  Resolution: 300, 0 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: separated
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 96
  Planar Configuration: single image plane
  Software: Adobe Photoshop CS2 Macintosh
  DateTime: 2007:12:02 14:43:35
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 11226 bytes
  EXIFIFDOffset: 0xb5300
  ICC Profile: <present>, 557168 bytes
TIFF Directory at offset 0xb5300 (742144)
  ColorSpace: 65535
  PixelXDimension: 2717
  PixelYDimension: 385
m5-d0f86ab189cbe900ec389ca6d7464713.tif:
TIFF Directory at offset 0x8 (8)
  Image Width: 2717 Image Length: 1
  Resolution: 300, 300 pixels/inch
  Compression Scheme: JPEG
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 96
  Planar Configuration: single image plane
  HostComputer: 
  Software: Adobe Photoshop CS2 Macintosh
  DateTime: 2007:12:02 14:43:35
  EXIFIFDOffset: 0xb5300
  ICC Profile: <present>, 557168 bytes
  JPEG Tables: (285 bytes)
TIFF Directory at offset 0xb5300 (742144)
  ColorSpace: 65535
  PixelXDimension: 4262557
  PixelYDimension: 385

```
### m1-d1d366d7965db766c19a66c7a2ccbb6b.tif

### m2-d1d366d7965db766c19a66c7a2ccbb6b.tif

### m3-d1d366d7965db766c19a66c7a2ccbb6b.tif

### m4-d1d366d7965db766c19a66c7a2ccbb6b.tif

### m5-d1d366d7965db766c19a66c7a2ccbb6b.tif

### m6-d1d366d7965db766c19a66c7a2ccbb6b.tif

  * Origin: {{{http://www.ilgridodeipoveri.org/gdp/images/img_11312.tiff}}}

#### Notes

```
m1-d1d366d7965db766c19a66c7a2ccbb6b.tif:
m2-d1d366d7965db766c19a66c7a2ccbb6b.tif:
TIFF Directory at offset 0x2bbe2 (179170)
  Image Width: 324 Image Length: 450
  Bits/Sample: 8
  Sample Format: unsigned integer
  Compression Scheme: LZW
  Extra Samples: 1<assoc-alpha>
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 4
  Rows/Strip: 37477
  Planar Configuration: single image plane
  Software: M	c OS X 10.4.11 (8S165)
  DateTime: 2008:06:17 10:03:36
  Artist: Mﬂtteo Della Torrg
  ICC Profile: <present>, 3176 bytes
  Predictor: horizontal differencing 2 (0x2)
m3-d1d366d7965db766c19a66c7a2ccbb6b.tif:
m4-d1d366d7965db766c19a66c7a2ccbb6b.tif:
m5-d1d366d7965db766c19a66c7a2ccbb6b.tif:
m6-d1d366d7965db766c19a66c7a2ccbb6b.tif:

```
### d274ea7f91216b3f5125acb4c138870e.tif

  * Origin: {{{http://www.cfav.co.uk/misc/projector/sch_f56_imi_g15_blhq_rev.tif}}}

#### Notes

```
TIFF Directory at offset 0x75bca0 (7716000)
  Subfile Type: (0 = 0x0)
  Image Width: 1388 Image Length: 1036
  Resolution: 0, 0
  Bits/Sample: 16
  Sample Format: void
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Halftone Hints: light 0 dark 0
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 1
  Min Sample Value: 0
  Max Sample Value: 65535
  Planar Configuration: single image plane
  Software: ActivR

```
### d664a73588796b59191ad8628065f04a.tif

  * Origin: {{{http://www.nag.ru/goodies/certificates/other/licence8.tif}}}

#### Notes

```
TIFF Directory at offset 0x400 (1024)
  Subfile Type: (0 = 0x0)
  Image Width: 4956 Image Length: 7014
  Resolution: 600, 600 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 51
  Planar Configuration: single image plane
  Software: Oi/GFS, writer v00.06.00P, (c) Wang Labs, Inc. 1990, 1991
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x8 (8)
  Image Width: 1239 Image Length: 1754
  Resolution: 150, 150
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 2, 2
  Samples/Pixel: 3
  Rows/Strip: 1754
  Planar Configuration: single image plane
  JpegInterchangeFormat: 232
  JpegInterchangeFormatLength: 623
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x358 (856)
  Subfile Type: reduced-resolution image (1 = 0x1)
  Image Width: 64 Image Length: 90
  Resolution: 8, 8
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: min-is-white
  Rows/Strip: 90
  Planar Configuration: single image plane

```
### e00804b3169008f1c00bf250edccdae4.tif

  * Origin: {{{http://www.nhinb.gov.tw/upfiles/adupload/dwn1285509594.tif}}}

#### Notes

```
TIFF Directory at offset 0x1374a (79690)
  Subfile Type: (0 = 0x0)
  Image Width: 1664 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: LZW
  Photometric Interpretation: min-is-black
  Thresholding: bilevel art scan
  Samples/Pixel: 1
  Rows/Strip: 59
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 0-3
  Make: RICOH
  Predictor: none 1 (0x1)
TIFF Directory at offset 0x1de2e (122414)
  Subfile Type: (0 = 0x0)
  Image Width: 1664 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 1-3
  Make: RICOH
TIFF Directory at offset 0x20e9e (134814)
  Subfile Type: (0 = 0x0)
  Image Width: 1664 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 2-3
  Make: RICOH

```
### m1-e07fcd0e2ea8a9f41c6baed2f651bb8d.tif

  * Origin: {{{http://jnul.huji.ac.il/dl/newspapers/hazefirah/index/25-1898/index2501.tif}}}

#### Notes

```

```
### e45931b568d12c9905b1db1775321972.tif

  * Origin: {{{http://www.livingsteel.org/media/shortlist2007/hideto_horike_uk02.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2362 Image Length: 1574
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 1574
  Planar Configuration: single image plane
  Make: Canon
  Model: Canon EOS D30
  Software: Adobe Photoshop CS2 Windows
  DateTime: 2007:06:13 13:42:54
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 5698 bytes
  EXIFIFDOffset: 0xaa95a4
  ICC Profile: <present>, 3144 bytes
TIFF Directory at offset 0xaa95a4 (11179428)
  ExposureTime: 3.000000
  FNumber: 22.000000
  ISOSpeedRatings: 100
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2007:05:10 00:50:33
  DateTimeDigitized: 2007:05:10 00:50:33
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 3.000000
  ShutterSpeedValue: -1.584946
  ApertureValue: 8.918869
  ExposureBiasValue: 0.000000
  MaxApertureValue: 4.000000
  SubjectDistance: 0.000000
  MeteringMode: 5
  Flash: 0
  FocalLength: 30.000000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 1
  PixelXDimension: 2362
  PixelYDimension: 1574
  FocalPlaneXResolution: 2421.524658
  FocalPlaneYResolution: 2420.167969
  FocalPlaneResolutionUnit: 2
  SensingMethod: 2

```
### ebad222e9402d00e371c92ab5da86e6b.tif

  * Origin: {{{http://www.martinsound.com/images/p3_mmu24.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 900 Image Length: 699
  Resolution: 220, 220 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: separated
  Samples/Pixel: 4
  Rows/Strip: 2
  Planar Configuration: single image plane
  Make: Canon
  Model: Canon PowerShot S20
  Software: Adobe Photoshop 7.0
  DateTime: 2002:07:24 12:44:15
  Dot Range: 0-255
  XMLPacket (XMP Metadata): Present
  Photoshop Data: <present>, 13850 bytes
  EXIFIFDOffset: 0x18d6e0
  ICC Profile: <present>, 557168 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x18d6e0 (1627872)
  ExposureTime: 0.005556
  FNumber: 5.600000
  ExifVersion: 0x30,0x32,0x31,0x30
  DateTimeOriginal: 2001:08:10 14:08:24
  DateTimeDigitized: 2001:08:10 14:08:24
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 6.000000
  ShutterSpeedValue: 7.491852
  ApertureValue: 4.970856
  ExposureBiasValue: 0.000000
  MaxApertureValue: 2.900000
  SubjectDistance: 0.727000
  MeteringMode: 2
  Flash: 0
  FocalLength: 13.000000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 65535
  PixelXDimension: 900
  PixelYDimension: 699
  FocalPlaneXResolution: 7366.906250
  FocalPlaneYResolution: 7349.282227
  FocalPlaneResolutionUnit: 2
  SensingMethod: 2

```
### ecf22eaecaf11fc75938973745138868.tif

  * Origin: {{{http://memory.loc.gov/pnp/habshaer/ca/ca1600/ca1604/data/002.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1696 Image Length: 2200
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Thresholding: 64 (0x40)
  FillOrder: msb-to-lsb
  Samples/Pixel: 1
  Rows/Strip: 2200
  Planar Configuration: single image plane
  DocumentName: /habshaer/ca/ca1600/ca1604/data/002.tif
  Software: Systems Integration Group,Inc,17:40:52
  DateTime: 1997:08:25:13:12:50
  Artist: Library of Congress

```
### m1-ed254aa9f390aab319728b42e00a73e7.tif

  * Origin: {{{Unknown}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Image Width: 1512 Image Length: 359
  Resolution: 296.64, 296.64
  Bits/Sample: 4
  Compression Scheme: ThunderScan
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 64
  Planar Configuration: single image plane
TIFF Directory at offset 0x1514c (86348)
  Image Width: 1512 Image Length: 359
  Resolution: 0, 296.64
  Bits/Sample: 1
  Compression Scheme: None
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 64
  Planar Configuration: single image plane

```
### efb780f70a7d94fa98adfc98d2aa8d50.tif

  * Origin: {{{http://www.mobiset.ru/photos/2008/september/02/motorola_zn5/raw2.tiff}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2624 Image Length: 1948
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: min-is-black
  Orientation: row 0 top, col 0 lhs
  Rows/Strip: 1948
  Planar Configuration: single image plane
  SubIFD Offsets: 11592
  Make: MOTOROLA INC
  Model: PIXL
  EXIFIFDOffset: 0x23c
  Software: R6637_G_81.00.47I_TOR
TIFF Directory at offset 0x23c (572)
  ExposureTime: 0.001502
  FNumber: 5.600000
  ExposureProgram: 2
  ISOSpeedRatings: 62
  ExifVersion: 0x30,0x31,0x31,0x30
  ShutterSpeedValue: 6.000000
  SubjectDistance: inf
  MeteringMode: 0
  LightSource: 0
  Flash: 0
  FocalLength: 5.800000
  MakerNote: ...
  FlashpixVersion: 0x30,0x31,0x30,0x30
  SensingMethod: 2

```
### m1-f0d7bcb90496c323c880a9773dfe93ff.tif

### m2-f0d7bcb90496c323c880a9773dfe93ff.tif

### m3-f0d7bcb90496c323c880a9773dfe93ff.tif

### m4-f0d7bcb90496c323c880a9773dfe93ff.tif

### m5-f0d7bcb90496c323c880a9773dfe93ff.tif

### m6-f0d7bcb90496c323c880a9773dfe93ff.tif

### m7-f0d7bcb90496c323c880a9773dfe93ff.tif

### m8-f0d7bcb90496c323c880a9773dfe93ff.tif

### m9-f0d7bcb90496c323c880a9773dfe93ff.tif

  * Origin: {{{Unknown}}}

#### Notes

```
m1-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 16
  Planar Configuration: single image plane
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JPEG Tables: (574 bytes)
m2-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 16
  Planar Configuration: single image plane
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JPEG Tables: (574 bytes)
m3-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 16
  Planar Configuration: single image plane
  JPEG Tables: (574 bytes)
m4-f0d7bcb90496c323c880a9773dfe93ff.tif:
m5-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Resolution: 16, 0
  Position: 0, 1.32383e+07
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Reference Black/White:
     0:     0   255
     1: 124.786   255
     2:   128   255
  JPEG Tables: (574 bytes)
m6-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Position: 0, 738.702
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Planar Configuration: single image plane
  Reference Black/White:
     0:     0   255
     1: 124.786   255
     2:   128   255
  JPEG Tables: (574 bytes)
m7-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 512 Image Length: 384
  Position: 0, 0
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 16
  Planar Configuration: single image plane
  HostComputer: 
  Reference Black/White:
     0:     0   255
     1:   128   255
     2:   128   255
  JPEG Tables: (574 bytes)
m8-f0d7bcb90496c323c880a9773dfe93ff.tif:
TIFF Directory at offset 0x5b6e (23406)
  Image Width: 20224 Image Length: 384
  Position: 40192, 0
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  Samples/Pixel: 3
  Rows/Strip: 16
  Planar Configuration: single image plane
  Reference Black/White:
     0: 9.96147e+06   255
     1:   128   255
     2:   128   255
  JPEG Tables: (574 bytes)
m9-f0d7bcb90496c323c880a9773dfe93ff.tif:

```
### f15fca5bfdef640840d8ea30570c8cea.tif

  * Origin: {{{http://www.oktoberpromotion.com/files/media/pascalfinkenauer3new-fotosvensindt.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 995 Image Length: 1181
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 8
  Compression Scheme: LZW
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 87
  Planar Configuration: single image plane
  SubIFD Offsets: 1347048
  Software: Adobe Photoshop CS3 Macintosh
  DateTime: 2008:11:13 18:29:11
  XMLPacket (XMP Metadata): Present
  RichTIFFIPTC Data: <present>, 8 bytes
  Photoshop Data: <present>, 12804 bytes
  EXIFIFDOffset: 0x148db0
  ICC Profile: <present>, 4376 bytes
  Predictor: horizontal differencing 2 (0x2)
TIFF Directory at offset 0x148db0 (1346992)
  ExifVersion: 0x30,0x32,0x32,0x30
  ColorSpace: 65535
  PixelXDimension: 995
  PixelYDimension: 1181

```
### m1-f228b1103fd7b629c08c1bbba94708e0.tif

### m2-f228b1103fd7b629c08c1bbba94708e0.tif

  * Origin: {{{http://das.ntl.gov.tw/xdcm/xml/show_img.jsp?file_name=cca100003-nw-tmsjp19480318-02-i.tif}}}

#### Notes

```
m1-f228b1103fd7b629c08c1bbba94708e0.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 4680 Image Length: 6400
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 6400
  Planar Configuration: single image plane
  ImageDescription: Adobe Photoshop 7.0
  Make: techsoft as - P.O.BOX 132, N-3201 Sandefjord,NORWAY
  Software: PixEdit Version 6.2.2.0, SN 246-50188-02,  used by Owner at Your Company Name
  DateTime: 2008:01:05 13:29:
0
  EXIFIFDOffset: 0x1d0
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x1d0 (464)
  ColorSpace: 65535
m2-f228b1103fd7b629c08c1bbba94708e0.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 4680 Image Length: 6400
  Resolution: 300, 300 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  FillOrder: msb-to-lsb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 6400
  Planar Configuration: single image plane
  ImageDescription: Adobe Photoshop 7.0
  Make: techsoft as - P.O.BOX 132, N-3201 Sandefjord,NORWAY
  Software: PixEdit Version 6.2.2.0, SN 246-50188-02,  used by Owner at Your Company Name
  DateTime: 2008:01:05 13:29:
0
  EXIFIFDOffset: 0x1d0
  Group 4 Options: (0 = 0x0)
TIFF Directory at offset 0x1d0 (464)
  ColorSpace: 65535

```
### m1-f4830e8d4fa458f78a09fcaaf260569c.tif

### m2-f4830e8d4fa458f78a09fcaaf260569c.tif

  * Origin: {{{http://www.abbasministries.org/press_release/images/abbas_high_res.tif}}}

#### Notes

```
m1-f4830e8d4fa458f78a09fcaaf260569c.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2085 Image Length: 1536
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 1
  YCbCr Positioning: cosited
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 167
  Planar Configuration: single image plane
  Make: FUJIFILM
  Model: FinePixS2Pro
  Software: Adobe Photos:op CS2 Windows
  XMLPacket (XMP Metadata): Present
  Copyright:     
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 7112 bytes
  EXIFIFDOffset: 0x839c8
  JPEG Tables: (558 bytes)
TIFF Directory at offset 0x839c8 (539080)
  ExposureTime: 0.016667
  ExposureProgram: 1
  ISOSpeedRatings: 1600
  ExifVersion: 0x30,0x32,0x32,0x30
  DateTimeOriginal: 2005:03:03 15:31:45
  DateTimeDigitized: 2005:03:03 15:31:45
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 3.200000
  ShutterSpeedValue: 0.000043
  ApertureValue: 4.500000
  BrightnessValue: 1.000000
  ExposureBiasValue: 0.000000
  MeteringMode: 3
  LightSource: 0
  Flash: 9
  FocalLength: 34.000000
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 65535
  PixelXDimension: 2085
  PixelYDimension: 1536
  FocalPlaneXResolution: 1007.000000
  FocalPlaneYResolution: 1007.000000
  FocalPlaneResolutionUnit: 3
  SensingMethod: 2
  CustomRendered: 0
  ExposureMode: 1
  WhiteBalance: 0
  FocalLengthIn35mmFilm: 51
  SceneCaptureType: 0
  Contrast: 2
  Saturation: 0
  Sharpness: 2
  SubjectDistanceRange: 0
m2-f4830e8d4fa458f78a09fcaaf260569c.tif:
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 2085 Image Length: 1536
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 1
  YCbCr Positioning: cosited
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 167
  Planar Configuration: single image plane
  Make: FUJIFILM
  Model: FinePixS2Pro
  Software: Adobe Photoshop CS2 Windows
  DateTime: 2006:11:16 22:13:39
  XMLPacket (XMP Metadata): Present
  Copyright:    Å
  RichTIFFIPTC Data: <present>, 16 bytes
  Photoshop Data: <present>, 7112 bytes
  EXIFIFDOffset: 0x839c8
  JPEG Tables: (558 bytes)
TIFF Directory at offset 0x839c8 (539080)
  ExposureTime: 0.016667
  FNumber: 4.800000
  ExposureProgram: 1
  ISOSpeedRatings: 1600
  ExifVersion: 0x30,0x32,0x32,0x30
  DateTimeOriginal: 2005:0û:03 15:31:45
  DateTimeDigitized: 2005:03:03 15:31:45
  ComponentsConfiguration: 0x1,0x2,0x3,0x0
  CompressedBitsPerPixel: 3.200000
  ShutterSpeedValue: 6.000000
  ApertureValue: 4.500000
  BrightnessValue: 1.000000
  LightSource: 0
  Flash: 9
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 65535
  PixelXDimension: 2085
  PixelYDimension: 1536
  FocalPlaneYResolution: 1007.000000
  FocalPlaneResolutionUnit: 3
  SensingMethod: 2
  CustomRendered: 0
  ExposureMode: 1
  WhiteBalance: 0
  FocalLengthIn35mmFilm: 51
  SceneCaptureType: 0
  Contrast: 2
  Sharpness: 2
  SubjectDistanceRange: 0

```
### f4bcc246f3471102a2dea2ee9153b372.tif

  * Origin: {{{http://www.snowbound.com/images/circledot.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: (0 = 0x0)
  Image Width: 1336 Image Length: 548
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 2
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 548
  Planar Configuration: single image plane
  DateTime: 06:01:1998
  Artist: Copyright Snowbound Software 1998
  JpegInterchangeFormat: 504
TIFF Directory at offset 0x1150b (70923)
  Subfile Type: (0 = 0x0)
  Image Width: 1336 Image Length: 548
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 2
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 548
  Planar Configuration: single image plane
  DateTime: 06:01:1998
  Artist: Copyright Snowbound Software 1998
  JpegInterchangeFormat: 71419
TIFF Directory at offset 0x19fbf (106431)
  Subfile Type: (0 = 0x0)
  Image Width: 1336 Image Length: 548
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 2
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 548
  Planar Configuration: single image plane
  DateTime: 06:01:1998
  Artist: Copyright Snowbound Software 1998
  JpegInterchangeFormat: 106927
TIFF Directory at offset 0x2b97b (178555)
  Subfile Type: (0 = 0x0)
  Image Width: 1336 Image Length: 548
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  FillOrder: msb-to-lsb
  YCbCr Subsampling: 2, 2
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 548
  Planar Configuration: single image plane
  DateTime: 06:01:1998
  Artist: Copyright Snowbound Software 1998
  JpegInterchangeFormat: 179051

```
### f505d8aaa96b8da1a1c92363b898f97a.tif

  * Origin: {{{http://korejtko.net/wp-content/uploads/2008/11/148222981.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Image Width: 350 Image Length: 233
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 233
  Planar Configuration: single image plane
  Software: Capture NX 2.0.0 W
  DateTime: 2008:11:11 22:18:57
  XMLPacket (XMP Metadata): Present
  EXIFIFDOffset: 0x8397
  ICC Profile: <present>, 2756 bytes
TIFF Directory at offset 0x8397 (33687)
  ExifVersion: 0x30,0x32,0x32,0x30
  MakerNote: 0x4e,0x69,0x6b,0x6f,0x6e,0x0,0x2,0x0,0x0,0x0,0x49,0x49,0x2a,0x0,0x8,0x0,0x0,0x0,0x7,0x0,0x1,0x0,0x7,0x0,0x4,0x0,0x0,0x0,0x30,0x32,0x31,0x30,0x11,0x0,0x4,0x0,0x1,0x0,0x0,0x0,0xd4,0x0,0x0,0x0,0xa1,0x0,0x7,0x0,0x38,0x0,0x0,0x0,0x62,0x0,0x0,0x0,0x9,0xe,0x2,0x0,0x13,0x0,0x0,0x0,0x9a,0x0,0x0,0x0,0xe,0xe,0x7,0x0,0x1e,0x0,0x0,0x0,0xae,0x0,0x0,0x0,0x10,0xe,0x4,0x0,0x1,0x0,0x0,0x0,0x32,0x1,0x0,0x0,0x22,0xe,0x3,0x0,0x4,0x0,0x0,0x0,0xcc,0x0,0x0,0x0,0x0,0x0,0x0,0x0,0x2b,0x65,0x4,0x0,0x30,0x0,0x0,0x0,0x42,0x41,0x3d,0x50,0x4f,0x4c,0x4f,0x4e,0x4b,0x4f,0x4e,0x4b,0x50,0x4f,0x4c,0x51,0x50,0x4d,0x52,0x50,0x4d,0x52,0x51,0x4e,0x52,0x51,0x4e,0x53,0x52,0x4e,0x53,0x52,0x4e,0x54,0x53,0x4f,0x55,0x53,0x4f,0x55,0x54,0x50,0x56,0x54,0x50,0x56,0x55,0x51,0x43,0x61,0x70,0x74,0x75,0x72,0x65,0x20,0x4e,0x58,0x20,0x32,0x2e,0x30,0x2e,0x30,0x20,0x57,0x0,0x33,0x30,0x31,0x30,0x30,0x2,0x0,0x1,0x0,0x0,0x0,0xf,0x85,0x0,0x0,0x0,0x0,0x0,0x1,0x2,0x0,0x0,0x0,0xab,0x84,0x0,0x0,0x0,0x0,0x1,0x1,0x8,0x0,0x8,0x0
  FlashpixVersion: 0x30,0x31,0x30,0x30
  ColorSpace: 65535
TIFF Directory at offset 0x850f (34063)
  Image Width: 160 Image Length: 106
  Resolution: 72, 72 pixels/inch
  Bits/Sample: 8
  Compression Scheme: None
  Photometric Interpretation: RGB color
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 3
  Rows/Strip: 106
  Planar Configuration: single image plane

```
### m1-f55287249b20fd368b4683f8336153d3.tif

### m2-f55287249b20fd368b4683f8336153d3.tif

  * Origin: {{{http://www.aibsnleawbtc.org/appeal1.tif}}}

#### Notes

```
m1-f55287249b20fd368b4683f8336153d3.tif:
TIFF Directory at offset 0x9fac (40876)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 1137
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: LZW
  Photometric Interpretation: min-is-black
  Samples/Pixel: 1
  Rows/Strip: 56
  Planar Configuration: single image plane
  Page Number: 0-0
  Software: Windows NT Fax Server
  Predictor: none 1 (0x1)
m2-f55287249b20fd368b4683f8336153d3.tif:
TIFF Directory at offset 0x9fac (40876)
  Subfile Type: (0 = 0x0)
  Image Width: 1728 Image Length: 1137
  Resolution: 204, 98 pixels/inch
  Bits/Sample: 1
  Compression Scheme: LZW
  Photometric Interpretation: min-is-black
  Samples/Pixel: 1
  Rows/Strip: 56
  Planar Configuration: single image plane
  Page Number: 0-0
  Software: Windows NT Fax Server
  Predictor: none 1 (0x1)

```
### f8179f8f5e566349cf3583a1ff3ea95c.tif

  * Origin: {{{http://www.mdu.edu.tw/~oga/news/052901.tif}}}

#### Notes

```
TIFF Directory at offset 0x97d2 (38866)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 0-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x1d8d2 (121042)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 1-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x2bc6a (179306)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 2-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x3a75e (239454)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 3-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x4e12c (319788)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 4-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x5f768 (391016)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 5-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x74484 (476292)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 6-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x89a64 (563812)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 7-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0x9d51e (644382)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 8-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0xaa530 (697648)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 9-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)
TIFF Directory at offset 0xb21b2 (729522)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1656 Image Length: 2339
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 1
  Compression Scheme: CCITT Group 3
  Photometric Interpretation: min-is-white
  Thresholding: bilevel art scan
  FillOrder: lsb-to-msb
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 2339
  Min Sample Value: 0
  Max Sample Value: 1
  Planar Configuration: single image plane
  Page Number: 10-11
  Make: RICOH
  Group 3 Options: (0 = 0x0)

```
### fa0aa927763ee4c7ebf43a5d05dfebc7.tif

  * Origin: {{{http://planningdevelopment.easthants.gov.uk/docsonlinefiles/62614_1.tif}}}

#### Notes

```
TIFF Directory at offset 0x8 (8)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1752 Image Length: 2352
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2352
  Planar Configuration: single image plane
  Page Number: 0-12
  DocumentName: DN0PUnknown serial  1222238320      350800000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:01
  Artist: IRIS 2001          
TIFF Directory at offset 0x36d6 (14038)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1752 Image Length: 2354
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2354
  Planar Configuration: single image plane
  Page Number: 1-12
  DocumentName: DN0PUnknown serial  1222238320      350900000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:03
  Artist: IRIS 2001          
TIFF Directory at offset 0x930e (37646)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1750 Image Length: 2352
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2352
  Planar Configuration: single image plane
  Page Number: 2-12
  DocumentName: DN0PUnknown serial  1222238320      351000000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:05
  Artist: IRIS 2001          
TIFF Directory at offset 0x14934 (84276)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1748 Image Length: 2352
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2352
  Planar Configuration: single image plane
  Page Number: 3-12
  DocumentName: DN0PUnknown serial  1222238320      351100000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:06
  Artist: IRIS 2001          
TIFF Directory at offset 0x1c5e6 (116198)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1750 Image Length: 2354
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2354
  Planar Configuration: single image plane
  Page Number: 4-12
  DocumentName: DN0PUnknown serial  1222238320      351200000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:07
  Artist: IRIS 2001          
TIFF Directory at offset 0x2494a (149834)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1752 Image Length: 2352
  Resolution: 200, 200
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 2
  Samples/Pixel: 3
  Rows/Strip: 2352
  Planar Configuration: single image plane
  Page Number: 5-12
  DocumentName: DN0PUnknown serial  1222238320      351300000.----!--
  Make: VendorID
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: ******************
  Artist: IRIS 2001          
  JpegInterchangeFormat: 150324
  JpegInterchangeFormatLength: 458524
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x94a50 (608848)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1752 Image Length: 2354
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2354
  Planar Configuration: single image plane
  Page Number: 6-12
  DocumentName: DN0PUnknown serial  1222238320      351400000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:13
  Artist: IRIS 2001          
TIFF Directory at offset 0x9c6e0 (640736)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1754 Image Length: 2356
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2356
  Planar Configuration: single image plane
  Page Number: 7-12
  DocumentName: DN0PUnknown serial  1222238320      351500000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:17
  Artist: IRIS 2001          
TIFF Directory at offset 0xa03b2 (656306)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1752 Image Length: 2348
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2348
  Planar Configuration: single image plane
  Page Number: 8-12
  DocumentName: DN0PUnknown serial  1222238320      351600000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:18
  Artist: IRIS 2001          
TIFF Directory at offset 0xaac18 (699416)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 1754 Image Length: 2350
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2350
  Planar Configuration: single image plane
  Page Number: 9-12
  DocumentName: DN0PUnknown serial  1222238320      351700000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:21
  Artist: IRIS 2001          
TIFF Directory at offset 0xb480e (739342)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 3518 Image Length: 2358
  Resolution: 200, 200
  Bits/Sample: 8
  Compression Scheme: Old-style JPEG
  Photometric Interpretation: YCbCr
  YCbCr Subsampling: 1, 2
  Samples/Pixel: 3
  Rows/Strip: 2358
  Planar Configuration: single image plane
  Page Number: 10-12
  DocumentName: DN0PUnknown serial  1222238320      351800000.----!--
  Make: VendorID
  Model: ProductID
  Software: xVCS V3.5      
  DateTime: ******************
  Artist: IRIS 2001          
  JpegInterchangeFormat: 739832
  JpegInterchangeFormatLength: 760181
  JpegProc: 1
  JpegRestartInterval: 0
TIFF Directory at offset 0x16e36e (1500014)
  Subfile Type: multi-page document (2 = 0x2)
  Image Width: 3516 Image Length: 2360
  Resolution: 200, 200
  Compression Scheme: CCITT Group 4
  Photometric Interpretation: min-is-white
  Rows/Strip: 2360
  Planar Configuration: single image plane
  Page Number: 11-12
  DocumentName: DN0PUnknown serial  1222238320      351900000.----!--
  Make: Kodak
  Model: Kodak i200
  Software: xVCS V3.5      
  DateTime: 2008:09:24 10:19:37
  Artist: IRIS 2001          

```
### m1-fe50c06bcf744c640005967082a93ead.tif

  * Origin: {{{http://www.arkansashighways.com/maps/counties/mlafa.tif}}}

#### Notes

```
TIFF Directory at offset 0x175aba (1530554)
  Subfile Type: (0 = 0x0)
  Image Width: 7200 Image Length: 12000
  Resolution: 200, 200 pixels/inch
  Bits/Sample: 96
  Compression Scheme: LZW
  Photometric Interpretation: min-is-black
  Thresholding: error diffused
  Orientation: row 0 top, col 0 lhs
  Samples/Pixel: 1
  Rows/Strip: 13
  Planar Configuration: single image plane
  Make: Oce
  DateTime: 2007:08:27 09:03:28
  TargetPrinter: 

```
