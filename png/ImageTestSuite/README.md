# ImageTestSuite &mdash; PNG

This folder contains images from the `imagetestsuite` located at:

https://code.google.com/archive/p/imagetestsuite/

Notes from that project below.

---

# Introduction

The PNG testsuite is a collection of [PNG images](http://en.wikipedia.org/wiki/Portable_Network_Graphics) from publicly available
sources, intended to help verify the correct operation of PNG image
decoders when presented with malformed or esoteric characteristics.

It is not the intention of this testsuite to verify the correct rendering of
images, but rather to ensure safe operation when presented with malformed
data, esoteric characteristics, edge cases, and pathological input. If you're interested in verifying correct rendering, you should check out the official PNG testsuite, [PngSuite](http://www.schaik.com/pngsuite/).

Your decoder or application should gracefully handle any errors while
attempting to render these images. To read more about how these testsuites are
generated and their intended use, see AboutTestSuite.

# Specification

These images were selected based on the number of execution paths explored with [libpng-1.2.34](http://www.libpng.org/pub/png/libpng.html). As every png chunk includes a 32bit CRC, in order to ensure good coverage using mutated data, it was necessary to test using the libpng API `png_set_crc_action(PNG_CRC_QUIET_USE, PNG_CRC_QUIET_USE)`. To maximise coverage in decoders which legitimately discard bad chunks, test images are provided in both an original and corrected form where appropriate.

Approximately 4295 unique lines of code are executed when decoding the
testsuite using libpng-1.2.34.

## Coverage

* Using the pngtest utility from the libpng distribution, of the 9139 total lines, 4295 are executed (~50%).

![](http://chart.apis.google.com/chart?chs=500x250&chd=t:287,81,330,99,559,28,104,1882,596,319,10,0&chl=png.c|pngerror.c|pngget.c|pngmem.c|pngread.c|pngrio.c|pngrtran.c|pngrutil.c|pngset.c|pngtest.c|pngtrans.c|sysmacros.h&cht=p&chtt=Distribution%20of%20Executed%20Lines%20by%20File&ft=.png)
![](http://chart.apis.google.com/chart?chs=500x250&chd=t:150,115,345,47,337,7,2823,325,232,102,352,9&chl=png.c|pngerror.c|pngget.c|pngmem.c|pngread.c|pngrio.c|pngrtran.c|pngrutil.c|pngset.c|pngtest.c|pngtrans.c|sysmacros.h&cht=p&chtt=Distribution%20of%20Unexecuted%20Lines%20by%20File&ft=.png)
![](http://chart.apis.google.com/chart?chds=0,3000&chs=500x250&cht=bvs&chco=4D89F9,C6D9FD&chd=t:287,81,330,99,559,28,104,1882,596,319,10,0|150,115,345,47,337,7,2823,325,232,102,352,9&cht=bvs&chtt=Executed%20vs%20Unexecuted%20Lines%20Per%20File&ft=.png)

### Coverage Gaps

The majority of the unexecuted code is from the writing routines, whice are largely unused during decoder testing. A large portion of the code also handles runtime allocation failure.

# Testsuite Contents

## Legend

|| *Tag* || *Description*  ||
|| *T*   || *Trivial*<br>Any artistic/creative content contained in the image is believed to be ineligible for copyright, as it's trivial (solid colour, single pixel, simple shapes or patterns, etc.) (please note, [IANAL](http://en.wikipedia.org/wiki/IANAL). See also, TrivialContent. ||
|| *F*   || *Free*<br>The image is believed to be compatible with common free software distribution guidelines, such as [PD](http://en.wikipedia.org/wiki/Public_domain), [CC](http://en.wikipedia.org/wiki/Creative_Commons), or [GFDL](http://en.wikipedia.org/wiki/GFDL). See also, ImageFreedom.||
|| *O*   || *Origin Unkown*<br>The original creator or source of the image is currently unknown. Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you know the origin or creator, or can provide a replacement image. See also, OriginUnknown. ||
|| *N*   || *NSFW (Not Safe For Work)*<br>The image may contain potentially objectionable content. Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you have a suitable replacement image. See also, ObjectionableContent. ||
|| *U*   || *Fair Use / Fair Dealing*<br>The original source image is known to be distributed under a restrictive license, however, it is believed that it's use in verifying the correct operation of image decoders is [fair use](http://en.wikipedia.org/wiki/Fair_use)/[fair dealing](http://en.wikipedia.org/wiki/Fair_dealing)(non-commercial research) (please note, [IANAL](http://en.wikipedia.org/wiki/IANAL)). Please [create a new issue](http://code.google.com/p/imagetestsuite/issues/) if you have a suitable replacement image. See also, CopyrightIssues. ||

## Naming Convention

Images are named based on the md5 checksum of the original source image, prefixed
with modifier letters, for example

```
c-m8-d41d8cd98f00b204e9800998ecf8427e.png
```

This is an 8th generation mutation of a source image with checksum
d41d8cd98f00b204e9800998ecf8427e, and at least one chunk's checksum has been
corrected.

An origin containing "brokensuite" indicates the original source image is
derived from a testcase provided by the excellent
[sixlegs java png decoding library](http://code.google.com/p/javapng/). These
images do not contain any artistic content, but the project publishes them
under the LGPL.

## Images

### 008b8bb75b8a487dc5aac86c9abb06fb.png FT

  * Origin: {{{brokensuite:multiple_sbit.png}}}

#### Notes

```
008b8bb75b8a487dc5aac86c9abb06fb.png  multiple sBIT not allowed
ERROR: 008b8bb75b8a487dc5aac86c9abb06fb.png

```
### 0132cfdbd8ca323574a2072e7ed5014c.png FT

  * Origin: {{{brokensuite:multiple_srgb.png}}}

#### Notes

```
0132cfdbd8ca323574a2072e7ed5014c.png  multiple sRGB not allowed
ERROR: 0132cfdbd8ca323574a2072e7ed5014c.png

```
### 0301fde58080883e938b604cab9768ea.png FT

  * Origin: {{{brokensuite:srgb_after_plte.png}}}

#### Notes

```
0301fde58080883e938b604cab9768ea.png  sRGB must precede PLTE
ERROR: 0301fde58080883e938b604cab9768ea.png

```
### m1-04c2707d63235dd5ab2c66ee98a36521.png TO

  * Origin: {{{Unknown}}}

#### Notes

  * Image is damaged beyond recognition, some french text is visible.

```
m1-04c2707d63235dd5ab2c66ee98a36521.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-04c2707d63235dd5ab2c66ee98a36521.png  zlib: inflate error = -3 (data error)
m1-04c2707d63235dd5ab2c66ee98a36521.png  private, critical chunk IyND (warning)
ERROR: m1-04c2707d63235dd5ab2c66ee98a36521.png

```
### c-m2-0699098e769a2d80e60f33dbb3332b61.png TO

### m1-0699098e769a2d80e60f33dbb3332b61.png TO

### m2-0699098e769a2d80e60f33dbb3332b61.png TO

  * Origin: {{{Unknown}}}

#### Notes

  * Image is damaged beyond recognition

```
c-m2-0699098e769a2d80e60f33dbb3332b61.png  invalid pHYs unit specifier (147)
c-m2-0699098e769a2d80e60f33dbb3332b61.png  tEXt text contains NULL character(s)
c-m2-0699098e769a2d80e60f33dbb3332b61.png  zlib: inflate error = -3 (data error)
c-m2-0699098e769a2d80e60f33dbb3332b61.png  illegal (unless recently approved) unknown, public chunk iEND
ERROR: c-m2-0699098e769a2d80e60f33dbb3332b61.png
m1-0699098e769a2d80e60f33dbb3332b61.png  first chunk must be IHDR
m1-0699098e769a2d80e60f33dbb3332b61.png  illegal (unless recently approved) unknown, public chunk sHDR
m1-0699098e769a2d80e60f33dbb3332b61.png  first chunk must be IHDR
m1-0699098e769a2d80e60f33dbb3332b61.png  EOF while reading pHYs data
ERROR: m1-0699098e769a2d80e60f33dbb3332b61.png
m2-0699098e769a2d80e60f33dbb3332b61.png  invalid pHYs unit specifier (147)
m2-0699098e769a2d80e60f33dbb3332b61.png  CRC error in chunk pHYs (computed ccdc8c94, expected d2dd7efc)
m2-0699098e769a2d80e60f33dbb3332b61.png  tEXt text contains NULL character(s)
m2-0699098e769a2d80e60f33dbb3332b61.png  zlib: inflate error = -3 (data error)
m2-0699098e769a2d80e60f33dbb3332b61.png  illegal (unless recently approved) unknown, public chunk iEND
ERROR: m2-0699098e769a2d80e60f33dbb3332b61.png
Errors were detected in 3 of the 3 files tested.

```
### 073c98872b81d1004d750f18a4b5f732.png FT

  * Origin: {{{brokensuite:length_ster.png}}}

#### Notes

```
073c98872b81d1004d750f18a4b5f732.png  invalid sTER length
ERROR: 073c98872b81d1004d750f18a4b5f732.png

```
### 0839d93f8e77e21acd0ac40a80b14b7b.png U

  * Origin: {{{http://img504.imageshack.us/img504/7096/gilgagennaiohx6.png}}}

#### Notes

  * Adobe Photoshop CS2 Windows
  * Image is unlikely to be free to use, replacement welcome.

```
OK: 0839d93f8e77e21acd0ac40a80b14b7b.png (350x490, 24-bit RGB, non-interlaced, -2.5%).

```
### 0b7d50ac449fd59eb3de00647636d0c9.png FT

  * Origin: {{{brokensuite:length_chrm.png}}}

#### Notes

```
0b7d50ac449fd59eb3de00647636d0c9.png  invalid cHRM length
ERROR: 0b7d50ac449fd59eb3de00647636d0c9.png

```
### 0d466db9067b719df0b06ef441bf1ee7.png FT

  * Origin: {{{brokensuite:multiple_iccp.png}}}

#### Notes

```
0d466db9067b719df0b06ef441bf1ee7.png  multiple iCCP not allowed
ERROR: 0d466db9067b719df0b06ef441bf1ee7.png

```
### c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png TU

### m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png TU

  * Origin: {{{http://www.alkaka.com/imeg/Internet/1.PNG}}}

#### Notes

  * Images are damaged beyond recognition, but derived from likely non-free image. Replacement welcome.

```
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (141) (warning)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (242) (warning)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (7)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (227) (warning)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (14)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (9)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  zlib: inflate error = -3 (data error)
c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  EOF while reading tIME data
ERROR: c-m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed dae1adb2, expected 1132e69e)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed 0a15515f, expected 9dbadf56)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed 4fc1e207, expected 3f04b634)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (141) (warning)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (242) (warning)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (7)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed 6d2ad651, expected 8001598b)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  private (invalid?) IDAT row-filter type (227) (warning)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (14)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed ed29880b, expected 1d9b84e6)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  invalid IDAT row-filter type (9)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  CRC error in chunk IDAT (computed b6e19be7, expected 3e0634d3)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  zlib: inflate error = -3 (data error)
m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png  EOF while reading tIME data
ERROR: m1-125cdc39e13ce7c237b7b4a9e1d8f21c.png
Errors were detected in 2 of the 2 files tested.

```
### 138331052d7c6e4acebfaa92af314e12.png FT

  * Origin: {{{brokensuite:length_hist.png}}}

#### Notes

```
138331052d7c6e4acebfaa92af314e12.png  invalid number of hIST entries (14)
ERROR: 138331052d7c6e4acebfaa92af314e12.png

```
### 13f665c09e4b03cdbe2fff3015ec8aa7.png FT

  * Origin: {{{brokensuite:multiple_bkgd.png}}}

#### Notes

```
13f665c09e4b03cdbe2fff3015ec8aa7.png  multiple bKGD not allowed
ERROR: 13f665c09e4b03cdbe2fff3015ec8aa7.png

```
### 18288f761922f9b9b00e927eaeb9e707.png T

  * Origin: {{{Unknown}}}

#### Notes
  
  * Crashes pngcheck -f
  * Damaged beyond recognition
  

```
Segmentation Fault
```
### 18bd8bf75e7a9b40b961dd501654ce0e.png TF

  * Origin: {{{brokensuite:hist_after_idat.png}}}

#### Notes

```
18bd8bf75e7a9b40b961dd501654ce0e.png  hIST must precede IDAT
ERROR: 18bd8bf75e7a9b40b961dd501654ce0e.png

```
### 18f9baf3834980f4b80a3e82ad45be48.png U

  * Origin: {{{http://muziektheaterapplaus.nl/algemeen/templates/oliver/images/MuziekTheaterApplaus.png}}}

#### Notes

  * Software: ULead System

```
OK: 18f9baf3834980f4b80a3e82ad45be48.png (118x79, 24-bit RGB, interlaced, 62.3%).

```
### c-m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png TU

### m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png TU

  * Origin: {{{http://www.jbiconnect.org/locale/en_AU/images/banner_right_connect.png}}}

#### Notes

```
c-m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed 28db6e2e, expected 52da2a66)
c-m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk IHDR (computed e0d16056, expected 97d650c0)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkTS (computed 844a7acb, expected 052610e6)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed a083d4c3, expected e0bf25a3)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed 80d73f6d, expected eb77bd16)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed 6c1f44fb, expected d93b8e9c)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed 28db6e2e, expected 52da2a66)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  CRC error in chunk mkBT (computed ecd1c296, expected 7729a6f7)
m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png  zlib: inflate error = -3 (data error)
ERROR: m1-19e0d1d0dfe97dca39e9d449c6b8b3d2.png
Errors were detected in 2 of the 2 files tested.

```
### 1ae14e57b7062597279134ff2eeb39c0.png FT

  * Origin: {{{brokensuite:multiple_trns.png}}}

#### Notes

```
1ae14e57b7062597279134ff2eeb39c0.png  multiple tRNS not allowed
ERROR: 1ae14e57b7062597279134ff2eeb39c0.png

```
### m1-1b5df699719c4a7cc8314ab9af139405.png U

  * Origin: {{{Unknown}}}

#### Notes

  * Image is damaged beyond recognition, an outline of a face is visible.

```
m1-1b5df699719c4a7cc8314ab9af139405.png  invalid IDAT row-filter type (119)
m1-1b5df699719c4a7cc8314ab9af139405.png  private (invalid?) IDAT row-filter type (173) (warning)
m1-1b5df699719c4a7cc8314ab9af139405.png  private (invalid?) IDAT row-filter type (224) (warning)
m1-1b5df699719c4a7cc8314ab9af139405.png  invalid IDAT row-filter type (90)
m1-1b5df699719c4a7cc8314ab9af139405.png  invalid IDAT row-filter type (107)
m1-1b5df699719c4a7cc8314ab9af139405.png  zlib: inflate error = -3 (data error)
ERROR: m1-1b5df699719c4a7cc8314ab9af139405.png

```
### 1b9a48cf04466108f6f2d225d100edbf.png TF

  * Origin: {{{brokensuite:pcal_after_idat.png}}}

#### Notes

```
1b9a48cf04466108f6f2d225d100edbf.png  sCAL must precede IDAT
1b9a48cf04466108f6f2d225d100edbf.png  pHYs must precede IDAT
1b9a48cf04466108f6f2d225d100edbf.png  pCAL must precede IDAT
ERROR: 1b9a48cf04466108f6f2d225d100edbf.png

```
### 1bcc34d49e56a2fba38490db206328b8.png TF

  * Origin: {{{brokensuite:multiple_scal.png}}}

#### Notes

```
1bcc34d49e56a2fba38490db206328b8.png  multiple sCAL not allowed
ERROR: 1bcc34d49e56a2fba38490db206328b8.png

```
### 1ebd73c1d3fbc89782f29507364128fc.png O

  * Origin: {{{Unknown}}}

#### Notes

  * Origin unknown, but likely non-free. Contains the text "leeroy" and photograph of a man.

```
OK: 1ebd73c1d3fbc89782f29507364128fc.png (110x110, 24-bit RGB, non-interlaced, -54.6%).

```
### c-m1-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m2-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m5-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m6-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m7-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### c-m8-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m1-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m2-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m3-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m4-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m5-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m6-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m7-1f97f040d0b6b26faeb0a1a7f1499590.png TO

### m8-1f97f040d0b6b26faeb0a1a7f1499590.png TO

  * Origin: {{{Unknown}}}

#### Notes

  * Damaged beyond recognition.

```
c-m1-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m1-1f97f040d0b6b26faeb0a1a7f1499590.png  invalid sCAL length
c-m1-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading Imag data
ERROR: c-m1-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m2-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m2-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
c-m2-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: c-m2-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png  invalid sCAL unit specifier (67)
c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: c-m3-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m5-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m5-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
c-m5-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: c-m5-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m6-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m6-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk IFND
ERROR: c-m6-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m7-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m7-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
c-m7-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: c-m7-1f97f040d0b6b26faeb0a1a7f1499590.png
c-m8-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m8-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
c-m8-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: c-m8-1f97f040d0b6b26faeb0a1a7f1499590.png
m1-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m1-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m1-1f97f040d0b6b26faeb0a1a7f1499590.png  invalid sCAL length
m1-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading Imag data
ERROR: m1-1f97f040d0b6b26faeb0a1a7f1499590.png
m2-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m2-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk pHYs (computed 91a71c6f, expected 9df55a60)
m2-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed 0d8f0029, expected 09c59193)
m2-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m2-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m2-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m2-1f97f040d0b6b26faeb0a1a7f1499590.png
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk pHYs (computed 91a71c6f, expected 9df55a60)
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed 0d8f0029, expected 09c59193)
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  invalid sCAL unit specifier (67)
m3-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m3-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m3-1f97f040d0b6b26faeb0a1a7f1499590.png
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  first chunk must be IHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk dHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  first chunk must be IHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk bHYs
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  first chunk must be IHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  first chunk must be IHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  invalid sCAL unit specifier (67)
m4-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  first chunk must be IHDR
m4-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m4-1f97f040d0b6b26faeb0a1a7f1499590.png
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk oFFs (computed ec472581, expected 45a5f521)
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk pHYs (computed 91a71c6f, expected 9df55a60)
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed 0d8f0029, expected 09c59193)
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m5-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m5-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m5-1f97f040d0b6b26faeb0a1a7f1499590.png
m6-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed cda26ea1, expected 09c59193)
m6-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m6-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk IFND
ERROR: m6-1f97f040d0b6b26faeb0a1a7f1499590.png
m7-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m7-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk pHYs (computed 91a71c6f, expected 9df55a60)
m7-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed 0d8f0029, expected 09c59193)
m7-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m7-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m7-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m7-1f97f040d0b6b26faeb0a1a7f1499590.png
m8-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk IHDR (computed dd10c7bd, expected f87b9861)
m8-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk pHYs (computed 91a71c6f, expected 9df55a60)
m8-1f97f040d0b6b26faeb0a1a7f1499590.png  CRC error in chunk vpAg (computed 0d8f0029, expected 09c59193)
m8-1f97f040d0b6b26faeb0a1a7f1499590.png  illegal (unless recently approved) unknown, public chunk aDAT
m8-1f97f040d0b6b26faeb0a1a7f1499590.png:  invalid chunk name " by " (20 62 79 20)
m8-1f97f040d0b6b26faeb0a1a7f1499590.png  EOF while reading  by  data
ERROR: m8-1f97f040d0b6b26faeb0a1a7f1499590.png
Errors were detected in 15 of the 15 files tested.

```
### c-m1-1fc0c0de88608a9445d6f98a544b5abc.png TU

### m1-1fc0c0de88608a9445d6f98a544b5abc.png TU

  * Origin: {{{http://www.dayandnight.lv/images/techn/back_en.png}}}

#### Notes

  * Likely non-free, but trivial contents.

```
c-m1-1fc0c0de88608a9445d6f98a544b5abc.png  tEXt keyword is longer than 79 characters
c-m1-1fc0c0de88608a9445d6f98a544b5abc.png  iTXt keyword is longer than 79 characters
c-m1-1fc0c0de88608a9445d6f98a544b5abc.png  private, critical chunk IdND (warning)
c-m1-1fc0c0de88608a9445d6f98a544b5abc.png  file doesn't end with an IEND chunk
ERROR: c-m1-1fc0c0de88608a9445d6f98a544b5abc.png
m1-1fc0c0de88608a9445d6f98a544b5abc.png  tEXt keyword is longer than 79 characters
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk mkTS (computed 0e7e8c98, expected eda6716d)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk mkBT (computed 6c7f5095, expected 3f7455f9)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk mkBT (computed fd3d7288, expected add7a3c2)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk mkBT (computed e206b6a6, expected 7729a6f7)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  iTXt keyword is longer than 79 characters
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk iTXt (computed 32bfd0de, expected aa50e890)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  private, critical chunk IdND (warning)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  CRC error in chunk IdND (computed 97cd4c55, expected ae426082)
m1-1fc0c0de88608a9445d6f98a544b5abc.png  file doesn't end with an IEND chunk
ERROR: m1-1fc0c0de88608a9445d6f98a544b5abc.png
Errors were detected in 2 of the 2 files tested.

```
### c-m2-272ae9468b7883e5cf61873a17271fb4.png TO

### m1-272ae9468b7883e5cf61873a17271fb4.png TO

### m2-272ae9468b7883e5cf61873a17271fb4.png TO

  * Origin: {{{Unknown}}}

#### Notes

  * Damaged beyond recognition.

```
c-m2-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (213) (warning)
c-m2-272ae9468b7883e5cf61873a17271fb4.png  invalid IDAT row-filter type (124)
c-m2-272ae9468b7883e5cf61873a17271fb4.png  invalid zTXt compression method (120)
c-m2-272ae9468b7883e5cf61873a17271fb4.png  illegal reserved-bit-set chunk zTot
c-m2-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk zTXE
c-m2-272ae9468b7883e5cf61873a17271fb4.png:  invalid chunk name "I�ND" (49 ffffffd0 4e 44)
c-m2-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk I�ND
ERROR: c-m2-272ae9468b7883e5cf61873a17271fb4.png
m1-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk sRGd
m1-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (208) (warning)
m1-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (211) (warning)
m1-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (206) (warning)
m1-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (153) (warning)
m1-272ae9468b7883e5cf61873a17271fb4.png  invalid IDAT row-filter type (37)
m1-272ae9468b7883e5cf61873a17271fb4.png  invalid zTXt compression method (120)
m1-272ae9468b7883e5cf61873a17271fb4.png  illegal reserved-bit-set chunk zTot
m1-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk zTXE
m1-272ae9468b7883e5cf61873a17271fb4.png:  invalid chunk name "I�ND" (49 ffffffd0 4e 44)
m1-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk I�ND
ERROR: m1-272ae9468b7883e5cf61873a17271fb4.png
m2-272ae9468b7883e5cf61873a17271fb4.png  private (invalid?) IDAT row-filter type (213) (warning)
m2-272ae9468b7883e5cf61873a17271fb4.png  invalid IDAT row-filter type (124)
m2-272ae9468b7883e5cf61873a17271fb4.png  CRC error in chunk IDAT (computed bc293aba, expected 81be9b02)
m2-272ae9468b7883e5cf61873a17271fb4.png  CRC error in chunk zTXt (computed a6ccd434, expected 98310798)
m2-272ae9468b7883e5cf61873a17271fb4.png  CRC error in chunk zTXt (computed 62b9ea06, expected 0c12e284)
m2-272ae9468b7883e5cf61873a17271fb4.png  CRC error in chunk zTXt (computed 810f8596, expected 810fd196)
m2-272ae9468b7883e5cf61873a17271fb4.png  invalid zTXt compression method (120)
m2-272ae9468b7883e5cf61873a17271fb4.png  CRC error in chunk zTXt (computed 5fc2f3c2, expected 5f3947e2)
m2-272ae9468b7883e5cf61873a17271fb4.png  illegal reserved-bit-set chunk zTot
m2-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk zTXE
m2-272ae9468b7883e5cf61873a17271fb4.png:  invalid chunk name "I�ND" (49 ffffffd0 4e 44)
m2-272ae9468b7883e5cf61873a17271fb4.png  illegal (unless recently approved) unknown, public chunk I�ND
ERROR: m2-272ae9468b7883e5cf61873a17271fb4.png
Errors were detected in 3 of the 3 files tested.

```
### 2a6ff5f8106894b22dad3ce99673481a.png U

  * Origin: {{{http://magnet.caltech.edu/images/m7.png}}}

#### Notes

```
2a6ff5f8106894b22dad3ce99673481a.png  iCCP not allowed with sRGB
ERROR: 2a6ff5f8106894b22dad3ce99673481a.png

```
### 2d641a11233385bb37a524ff010a8531.png U

  * Origin: {{{http://www.coherentpdf.com/logo-cloud.png}}}

#### Notes

```
OK: 2d641a11233385bb37a524ff010a8531.png (162x159, 32-bit RGB+alpha, non-interlaced, 75.2%).

```
### c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png TO

### c-m2-2dc3bdd9274b121b851fa536b0e35b6a.png TO

### m1-2dc3bdd9274b121b851fa536b0e35b6a.png TO

### m2-2dc3bdd9274b121b851fa536b0e35b6a.png TO

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid cHRM green point 13422.1 0.6
c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid bKGD length
c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png  illegal reserved-bit-set chunk pHrs
c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid chunk length (too large)
ERROR: c-m1-2dc3bdd9274b121b851fa536b0e35b6a.png
c-m2-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid cHRM blue point 168.296 0.42352
c-m2-2dc3bdd9274b121b851fa536b0e35b6a.png  illegal reserved-bit-set chunk pHrs
c-m2-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid chunk length (too large)
ERROR: c-m2-2dc3bdd9274b121b851fa536b0e35b6a.png
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk IHDR (computed bb0c65a7, expected 3c0171e2)
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk gAMA (computed f37bf9ba, expected 0bfc6105)
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid cHRM green point 13422.1 0.6
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk cHRM (computed 8d71aff8, expected 9cba513c)
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid bKGD length
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  illegal reserved-bit-set chunk pHrs
m1-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid chunk length (too large)
ERROR: m1-2dc3bdd9274b121b851fa536b0e35b6a.png
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk IHDR (computed 03b002c2, expected 3c0171e2)
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk gAMA (computed f37bf9ba, expected 0bfc6105)
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid cHRM blue point 168.296 0.42352
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk cHRM (computed 42518ab3, expected 9cba513c)
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  CRC error in chunk oFFs (computed 70136083, expected fe75e54a)
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  illegal reserved-bit-set chunk pHrs
m2-2dc3bdd9274b121b851fa536b0e35b6a.png  invalid chunk length (too large)
ERROR: m2-2dc3bdd9274b121b851fa536b0e35b6a.png
Errors were detected in 4 of the 4 files tested.

```
### 31e3bc3eb811cff582b5feee2494fed8.png TF

  * Origin: {{{brokensuite:sbit_after_idat.png}}}

#### Notes

```
31e3bc3eb811cff582b5feee2494fed8.png  sBIT must precede IDAT
ERROR: 31e3bc3eb811cff582b5feee2494fed8.png

```
### 3625f98e00148cdc136c53bdcd2d2e1e.png TO

### c-3625f98e00148cdc136c53bdcd2d2e1e.png TO

### c-m1-3625f98e00148cdc136c53bdcd2d2e1e.png TO

### m1-3625f98e00148cdc136c53bdcd2d2e1e.png TO

### m2-3625f98e00148cdc136c53bdcd2d2e1e.png TO

  * Origin: {{{Unknown}}}

#### Notes

```
3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
3625f98e00148cdc136c53bdcd2d2e1e.png  zero length sPLT palette name
3625f98e00148cdc136c53bdcd2d2e1e.png  CRC error in chunk sPLT (computed 88723087, expected 8e000000)
3625f98e00148cdc136c53bdcd2d2e1e.png:  invalid chunk name "A" (41 00 01 ffffff86)
3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
3625f98e00148cdc136c53bdcd2d2e1e.png  EOF while reading A data
ERROR: 3625f98e00148cdc136c53bdcd2d2e1e.png
c-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
c-3625f98e00148cdc136c53bdcd2d2e1e.png  zero length sPLT palette name
c-3625f98e00148cdc136c53bdcd2d2e1e.png:  invalid chunk name "A" (41 00 01 ffffff86)
c-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
c-3625f98e00148cdc136c53bdcd2d2e1e.png  EOF while reading A data
ERROR: c-3625f98e00148cdc136c53bdcd2d2e1e.png
c-m1-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
c-m1-3625f98e00148cdc136c53bdcd2d2e1e.png  EOF while reading gAMA data
ERROR: c-m1-3625f98e00148cdc136c53bdcd2d2e1e.png
m1-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
m1-3625f98e00148cdc136c53bdcd2d2e1e.png  CRC error in chunk srLT (computed 158471d7, expected ce66668e)
m1-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
m1-3625f98e00148cdc136c53bdcd2d2e1e.png  EOF while reading gAMA data
ERROR: m1-3625f98e00148cdc136c53bdcd2d2e1e.png
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  illegal reserved-bit-set chunk sPuT
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  PLTE not allowed in INVALID image
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  zlib: inflate error = -3 (data error)
m2-3625f98e00148cdc136c53bdcd2d2e1e.png  first chunk must be IHDR
ERROR: m2-3625f98e00148cdc136c53bdcd2d2e1e.png
Errors were detected in 5 of the 5 files tested.

```
### 429104334d1fb6a58e17307883c17608.png TF

  * Origin: {{{brokensuite:sbit_after_plte.png}}}

#### Notes

```
429104334d1fb6a58e17307883c17608.png  sBIT must precede PLTE
ERROR: 429104334d1fb6a58e17307883c17608.png

```
### 42ec8668adb5dbc6581393f463976510.png TF

  * Origin: {{{brokensuite:trns_after_idat.png}}}

#### Notes

```
42ec8668adb5dbc6581393f463976510.png  tRNS must precede IDAT
ERROR: 42ec8668adb5dbc6581393f463976510.png

```
### 4389427591c18bf36e748172640862c3.png TF

  * Origin: {{{brokensuite:ster_mode.png}}}

#### Notes

```
4389427591c18bf36e748172640862c3.png  invalid sTER layout mode
ERROR: 4389427591c18bf36e748172640862c3.png

```
### 463d3570f92a6b6ecba0cc4fd9a7a384.png TF

  * Origin: {{{brokensuite:multiple_plte.png}}}

#### Notes

```
463d3570f92a6b6ecba0cc4fd9a7a384.png  multiple PLTE not allowed
ERROR: 463d3570f92a6b6ecba0cc4fd9a7a384.png

```
### c-m1-49e39033e275de9786d8c41f834c710b.png TO

### m1-49e39033e275de9786d8c41f834c710b.png TO

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-49e39033e275de9786d8c41f834c710b.png  tRNS not allowed in grayscale+alpha image
c-m1-49e39033e275de9786d8c41f834c710b.png  zlib: inflate error = -3 (data error)
c-m1-49e39033e275de9786d8c41f834c710b.png  illegal (unless recently approved) unknown, public chunk tEND
ERROR: c-m1-49e39033e275de9786d8c41f834c710b.png
m1-49e39033e275de9786d8c41f834c710b.png  CRC error in chunk IHDR (computed dd8baef7, expected 4d9f902b)
m1-49e39033e275de9786d8c41f834c710b.png  tRNS not allowed in grayscale+alpha image
m1-49e39033e275de9786d8c41f834c710b.png  zlib: inflate error = -3 (data error)
m1-49e39033e275de9786d8c41f834c710b.png  illegal (unless recently approved) unknown, public chunk tEND
ERROR: m1-49e39033e275de9786d8c41f834c710b.png
Errors were detected in 2 of the 2 files tested.

```
### 4aae896ba900c48c63cffc0cc9f8c4dc.png TF

  * Origin: {{{http://www.schaik.com/pngsuite/x00n0g01.png}}}
  * Origin: {{{brokensuite:x00n0g01.png}}}

#### Notes

```
4aae896ba900c48c63cffc0cc9f8c4dc.png  invalid IHDR image dimensions (0x0)
4aae896ba900c48c63cffc0cc9f8c4dc.png  file doesn't end with an IEND chunk
ERROR: 4aae896ba900c48c63cffc0cc9f8c4dc.png

```
### c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png

### m1-4bdd87fd0324f0a3d84d6905d17e1731.png

  * Origin: {{{http://farm3.static.flickr.com/2401/2263329466_036c167f2e_o.png}}}

#### Notes

  * A quick search doesn't reveal the flickr user who created this, as the license is usually published will update this if found.

```
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid tIME year (0)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (45)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (150) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (124)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (114)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (127)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (131) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (22)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (133) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (36)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (199) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (242) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (6)
c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-4bdd87fd0324f0a3d84d6905d17e1731.png
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid tIME year (0)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (45)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (150) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (124)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (114)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (127)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (131) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (22)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  CRC error in chunk IDAT (computed 1c93886a, expected 3577897a)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (133) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (36)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (199) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (242) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  invalid IDAT row-filter type (6)
m1-4bdd87fd0324f0a3d84d6905d17e1731.png  zlib: inflate error = -3 (data error)
ERROR: m1-4bdd87fd0324f0a3d84d6905d17e1731.png
Errors were detected in 2 of the 2 files tested.

```
### 4c5b82ba0a9c12356007bd71e52185b2.png

  * Origin: {{{http://www.riforma.it/pictures/frutta080321.png}}}

#### Notes

```
4c5b82ba0a9c12356007bd71e52185b2.png  invalid sRGB length
ERROR: 4c5b82ba0a9c12356007bd71e52185b2.png

```
### 4f14b7aab3a41855378c5517342598b9.png

  * Origin: {{{brokensuite:length_trns_palette.png}}}

#### Notes

```
4f14b7aab3a41855378c5517342598b9.png  invalid tRNS length for palette image
ERROR: 4f14b7aab3a41855378c5517342598b9.png

```
### 51a4d21670dc8dfa8ffc9e54afd62f5f.png

  * Origin: {{{http://www.carfolio.com/images/dbimages/zgas/manufacturers/id/5584/rolls-royce_logo.png}}}

#### Notes

```
OK: 51a4d21670dc8dfa8ffc9e54afd62f5f.png (160x278, 16-bit grayscale+alpha, interlaced, 71.4%).

```
### c-m1-559dcf17d281e285b7f09f943b9706de.png

### c-m2-559dcf17d281e285b7f09f943b9706de.png

### m1-559dcf17d281e285b7f09f943b9706de.png

### m2-559dcf17d281e285b7f09f943b9706de.png

  * Origin: {{{http://champions.mn/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://mapaurody.pl/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://adamvietnam.com/thegreatswim/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://santatividade.com.br/site/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.razorman.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.tcvb.org/site/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.floatsdown.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://master.weiqi.ru/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.gtk.ir/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://falcon-ua.cn/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.i-mh.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.friends4recovery.com/rainbow/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.obrazi.si//images/M_images/rating_star_blank.png}}}
  * Origin: {{{https://www.scrapwords.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://map-online.fr/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://notesandgracenotes.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://7sana.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.topproducercampus.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://klikkelapagading.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.cafe.prijedor.ba/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://masterchong.com/v2/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://neutral-clan.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://portalmangabeira.com/v2/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.pato.chumporn.police.go.th/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://kuantancentral.com.my/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://angloisraeli.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.axcesstuscaloosa.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://belindarice.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://linboo.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.tyrol-webdesign.at/seidlschaar2/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://horrormoviekillers.com/mainsitearea/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.alsat.tv/eng/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.circleboost.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.kovaraw.com/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.verdehattrick.com.ar/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.bowhunternation.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.railpage.cz/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://goaaal.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://www.videoshqip.net/images/M_images/rating_star_blank.png}}}
  * Origin: {{{http://bezboly.ru/templates/joomlafiles_green/images/rating_star_blank.png}}}

#### Notes

```
c-m1-559dcf17d281e285b7f09f943b9706de.png  invalid IDAT row-filter type (9)
ERROR: c-m1-559dcf17d281e285b7f09f943b9706de.png
c-m2-559dcf17d281e285b7f09f943b9706de.png  invalid sBIT length
c-m2-559dcf17d281e285b7f09f943b9706de.png  PLTE not allowed in grayscale image
c-m2-559dcf17d281e285b7f09f943b9706de.png  zlib: inflate error = -3 (data error)
ERROR: c-m2-559dcf17d281e285b7f09f943b9706de.png
m1-559dcf17d281e285b7f09f943b9706de.png  CRC error in chunk IHDR (computed ed8067bf, expected 9a875729)
m1-559dcf17d281e285b7f09f943b9706de.png  CRC error in chunk tRNS (computed 425e370a, expected f4381a37)
m1-559dcf17d281e285b7f09f943b9706de.png  invalid IDAT row-filter type (9)
ERROR: m1-559dcf17d281e285b7f09f943b9706de.png
m2-559dcf17d281e285b7f09f943b9706de.png  CRC error in chunk IHDR (computed 8832f8c7, expected 9a875729)
m2-559dcf17d281e285b7f09f943b9706de.png  invalid sBIT length
m2-559dcf17d281e285b7f09f943b9706de.png  PLTE not allowed in grayscale image
m2-559dcf17d281e285b7f09f943b9706de.png  zlib: inflate error = -3 (data error)
ERROR: m2-559dcf17d281e285b7f09f943b9706de.png
Errors were detected in 4 of the 4 files tested.

```
### 579294d4d8110fc64980dd72a5066780.png

  * Origin: {{{brokensuite:plte_too_many_entries_2.png}}}

#### Notes

```
579294d4d8110fc64980dd72a5066780.png  invalid number of PLTE entries (257)
ERROR: 579294d4d8110fc64980dd72a5066780.png

```
### c-m1-585dd0ac594e8226c49ae7986b8f47d3.png

### m1-585dd0ac594e8226c49ae7986b8f47d3.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-585dd0ac594e8226c49ae7986b8f47d3.png  invalid gAMA length
c-m1-585dd0ac594e8226c49ae7986b8f47d3.png  zlib: inflate error = -3 (data error)
c-m1-585dd0ac594e8226c49ae7986b8f47d3.png  illegal reserved-bit-set chunk IEmD
ERROR: c-m1-585dd0ac594e8226c49ae7986b8f47d3.png
m1-585dd0ac594e8226c49ae7986b8f47d3.png  CRC error in chunk IHDR (computed d0f6e06c, expected 498bc8ef)
m1-585dd0ac594e8226c49ae7986b8f47d3.png  invalid gAMA length
m1-585dd0ac594e8226c49ae7986b8f47d3.png  zlib: inflate error = -3 (data error)
m1-585dd0ac594e8226c49ae7986b8f47d3.png  illegal reserved-bit-set chunk IEmD
ERROR: m1-585dd0ac594e8226c49ae7986b8f47d3.png
Errors were detected in 2 of the 2 files tested.

```
### 586914b5d01d3889fb7bb5c44fe29771.png

### c-586914b5d01d3889fb7bb5c44fe29771.png

  * Origin: {{{Unknown}}}

#### Notes

```
586914b5d01d3889fb7bb5c44fe29771.png  CRC error in chunk bKGD (computed dfe780ae, expected 1f5dec03)
586914b5d01d3889fb7bb5c44fe29771.png  zlib: inflate error = -3 (data error)
ERROR: 586914b5d01d3889fb7bb5c44fe29771.png
c-586914b5d01d3889fb7bb5c44fe29771.png  zlib: inflate error = -3 (data error)
ERROR: c-586914b5d01d3889fb7bb5c44fe29771.png
Errors were detected in 2 of the 2 files tested.

```
### c-m1-58d30745083f25952342caafb6ee5f37.png

### m1-58d30745083f25952342caafb6ee5f37.png

  * Origin: {{{http://info.weather.yandex.net/informer/120x156/11120.png}}}

#### Notes

```
c-m1-58d30745083f25952342caafb6ee5f37.png  invalid IHDR image type (11)
c-m1-58d30745083f25952342caafb6ee5f37.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-58d30745083f25952342caafb6ee5f37.png
m1-58d30745083f25952342caafb6ee5f37.png  invalid IHDR image type (11)
m1-58d30745083f25952342caafb6ee5f37.png  CRC error in chunk IHDR (computed 164b6bd8, expected e421b305)
m1-58d30745083f25952342caafb6ee5f37.png  zlib: inflate error = -3 (data error)
ERROR: m1-58d30745083f25952342caafb6ee5f37.png
Errors were detected in 2 of the 2 files tested.

```
### c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png

### c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png

### m1-593d4b1a0b5d13b539c6c098dc5797ca.png

### m2-593d4b1a0b5d13b539c6c098dc5797ca.png

### m3-593d4b1a0b5d13b539c6c098dc5797ca.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (28)
c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (250) (warning)
c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (73)
c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (121)
ERROR: c-m2-593d4b1a0b5d13b539c6c098dc5797ca.png
c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (28)
c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (250) (warning)
c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (73)
c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (121)
ERROR: c-m3-593d4b1a0b5d13b539c6c098dc5797ca.png
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  first chunk must be IHDR
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  illegal (unless recently approved) unknown, public chunk vHDR
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  first chunk must be IHDR
m1-593d4b1a0b5d13b539c6c098dc5797ca.png:  invalid chunk name "IDA�" (49 44 41 ffffffaf)
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  first chunk must be IHDR
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  illegal critical, safe-to-copy chunk IDA�
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  first chunk must be IHDR
m1-593d4b1a0b5d13b539c6c098dc5797ca.png  no IDAT chunks
ERROR: m1-593d4b1a0b5d13b539c6c098dc5797ca.png
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (255) (warning)
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (28)
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (250) (warning)
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (73)
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (121)
m2-593d4b1a0b5d13b539c6c098dc5797ca.png  CRC error in chunk IDAT (computed 4c13f9e8, expected 5542ce25)
ERROR: m2-593d4b1a0b5d13b539c6c098dc5797ca.png
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (255) (warning)
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (28)
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  private (invalid?) IDAT row-filter type (250) (warning)
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (73)
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  invalid IDAT row-filter type (121)
m3-593d4b1a0b5d13b539c6c098dc5797ca.png  CRC error in chunk IDAT (computed 0deb5053, expected 5542ce25)
ERROR: m3-593d4b1a0b5d13b539c6c098dc5797ca.png
Errors were detected in 5 of the 5 files tested.

```
### m1-5ae377bebf643e2e53ba7038103e48c4.png

  * Origin: {{{http://upload.wikimedia.org/wikipedia/commons/thumb/3/33/Flag_of_rcnl.png/120px-Flag_of_rcnl.png}}}

#### Notes

```
m1-5ae377bebf643e2e53ba7038103e48c4.png  private (invalid?) IDAT row-filter type (185) (warning)
m1-5ae377bebf643e2e53ba7038103e48c4.png  invalid IDAT row-filter type (9)
m1-5ae377bebf643e2e53ba7038103e48c4.png  zlib: inflate error = -3 (data error)
m1-5ae377bebf643e2e53ba7038103e48c4.png  illegal (unless recently approved) unknown, public chunk sTXt
ERROR: m1-5ae377bebf643e2e53ba7038103e48c4.png

```
### 5b689479bd7e527c2385a40437272607.png

  * Origin: {{{brokensuite:srgb_after_idat.png}}}

#### Notes

```
5b689479bd7e527c2385a40437272607.png  sRGB must precede IDAT
ERROR: 5b689479bd7e527c2385a40437272607.png

```
### 5beaadc10dfdbf61124e98fdf8a5c191.png

  * Origin: {{{brokensuite:multiple_ster.png}}}

#### Notes

```
5beaadc10dfdbf61124e98fdf8a5c191.png  multiple sTER not allowed
ERROR: 5beaadc10dfdbf61124e98fdf8a5c191.png

```
### c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png

### m1-5e149c14dc7b7c16ff6bcedd1625ca31.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (7)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (247) (warning)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (246) (warning)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (10)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (13)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (9)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (5)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (6)
c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-5e149c14dc7b7c16ff6bcedd1625ca31.png
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (7)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  CRC error in chunk IDAT (computed 20dc9f00, expected a964ee42)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (247) (warning)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (246) (warning)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (10)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  CRC error in chunk IDAT (computed e4361d93, expected b9144328)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (13)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (9)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  private (invalid?) IDAT row-filter type (251) (warning)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (5)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  invalid IDAT row-filter type (6)
m1-5e149c14dc7b7c16ff6bcedd1625ca31.png  zlib: inflate error = -3 (data error)
ERROR: m1-5e149c14dc7b7c16ff6bcedd1625ca31.png
Errors were detected in 2 of the 2 files tested.

```
### 5e2b64196b9e014e0ed0a27873cafdb3.png

### c-5e2b64196b9e014e0ed0a27873cafdb3.png

  * Origin: {{{Unknown}}}

#### Notes

```
5e2b64196b9e014e0ed0a27873cafdb3.png  sRGB invalid rendering intent
5e2b64196b9e014e0ed0a27873cafdb3.png  CRC error in chunk sRGB (computed a9a3d8f0, expected aece1ce9)
5e2b64196b9e014e0ed0a27873cafdb3.png  invalid cHRM red point 168.412 0.33
5e2b64196b9e014e0ed0a27873cafdb3.png  CRC error in chunk cHRM (computed 1d9f341b, expected 9cba513c)
ERROR: 5e2b64196b9e014e0ed0a27873cafdb3.png
c-5e2b64196b9e014e0ed0a27873cafdb3.png  sRGB invalid rendering intent
c-5e2b64196b9e014e0ed0a27873cafdb3.png  invalid cHRM red point 168.412 0.33
ERROR: c-5e2b64196b9e014e0ed0a27873cafdb3.png
Errors were detected in 2 of the 2 files tested.

```
### m1-5efba06832cc674ae5d290ba7ebc2533.png

  * Origin: {{{Unknown}}}

#### Notes

```

```
### 611b294df9cf794eeaa1ffcc620bf6a4.png

  * Origin: {{{brokensuite:multiple_offs.png}}}

#### Notes

```
611b294df9cf794eeaa1ffcc620bf6a4.png  multiple oFFs not allowed
ERROR: 611b294df9cf794eeaa1ffcc620bf6a4.png

```
### 6399623892b45aa4901aa6e702c7a62d.png

  * Origin: {{{brokensuite:scal_negative.png}}}

#### Notes

```
6399623892b45aa4901aa6e702c7a62d.png  invalid negative sCAL value(s)
ERROR: 6399623892b45aa4901aa6e702c7a62d.png

```
### 64221ffc9050c92b8980326acc0e4194.png

  * Origin: {{{brokensuite:multiple_pcal.png}}}

#### Notes

```
64221ffc9050c92b8980326acc0e4194.png  multiple pCAL not allowed
ERROR: 64221ffc9050c92b8980326acc0e4194.png

```
### c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png

### m1-6593e140dba21ccb8c8724f8fe88fdb6.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (37)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  private (invalid?) IDAT row-filter type (181) (warning)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (12)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (100)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (98)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  zlib: inflate error = -3 (data error)
c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png  private (possibly invalid) zTXt compression method (132) (warning)
ERROR: c-m1-6593e140dba21ccb8c8724f8fe88fdb6.png
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  CRC error in chunk IHDR (computed 8cd29595, expected 3c0171e2)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (37)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  private (invalid?) IDAT row-filter type (181) (warning)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (12)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (100)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  CRC error in chunk IDAT (computed ad821b9e, expected ebadb2b8)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  invalid IDAT row-filter type (98)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  zlib: inflate error = -3 (data error)
m1-6593e140dba21ccb8c8724f8fe88fdb6.png  private (possibly invalid) zTXt compression method (132) (warning)
ERROR: m1-6593e140dba21ccb8c8724f8fe88fdb6.png
Errors were detected in 2 of the 2 files tested.

```
### 66ac49ef3f48ac9482049e1ab57a53e9.png

### c-m1-66ac49ef3f48ac9482049e1ab57a53e9.png

### c-m2-66ac49ef3f48ac9482049e1ab57a53e9.png

### c-m3-66ac49ef3f48ac9482049e1ab57a53e9.png

### m1-66ac49ef3f48ac9482049e1ab57a53e9.png

### m2-66ac49ef3f48ac9482049e1ab57a53e9.png

### m3-66ac49ef3f48ac9482049e1ab57a53e9.png

  * Origin: {{{http://i17.photobucket.com/albums/b76/icedlain/ubuntu.png}}}

#### Notes

```
OK: 66ac49ef3f48ac9482049e1ab57a53e9.png (80x15, 32-bit RGB+alpha, non-interlaced, 16.0%).
OK: c-m1-66ac49ef3f48ac9482049e1ab57a53e9.png (80x15, 32-bit RGB+alpha, non-interlaced, 16.0%).
c-m2-66ac49ef3f48ac9482049e1ab57a53e9.png  zlib: inflate error = -3 (data error)
c-m2-66ac49ef3f48ac9482049e1ab57a53e9.png  illegal critical, safe-to-copy chunk WTXt
ERROR: c-m2-66ac49ef3f48ac9482049e1ab57a53e9.png
OK: c-m3-66ac49ef3f48ac9482049e1ab57a53e9.png (80x15, 32-bit RGB+alpha, non-interlaced, 16.0%).
m1-66ac49ef3f48ac9482049e1ab57a53e9.png  CRC error in chunk gAMA (computed f41078d0, expected 0bfc6105)
m1-66ac49ef3f48ac9482049e1ab57a53e9.png  CRC error in chunk zTXt (computed 565f2318, expected bb0815b0)
ERROR: m1-66ac49ef3f48ac9482049e1ab57a53e9.png
m2-66ac49ef3f48ac9482049e1ab57a53e9.png  CRC error in chunk zTXt (computed 1d9c9e15, expected bb0815b0)
m2-66ac49ef3f48ac9482049e1ab57a53e9.png  zlib: inflate error = -3 (data error)
m2-66ac49ef3f48ac9482049e1ab57a53e9.png  illegal critical, safe-to-copy chunk WTXt
ERROR: m2-66ac49ef3f48ac9482049e1ab57a53e9.png
m3-66ac49ef3f48ac9482049e1ab57a53e9.png  CRC error in chunk zTXt (computed f6421cb4, expected bb0815b0)
ERROR: m3-66ac49ef3f48ac9482049e1ab57a53e9.png
Errors were detected in 4 of the 7 files tested.
No errors were detected in 3 of the 7 files tested.

```
### c-m1-6bfb149151f58d124d6fa76eaad75520.png

### c-m4-6bfb149151f58d124d6fa76eaad75520.png

### m1-6bfb149151f58d124d6fa76eaad75520.png

### m2-6bfb149151f58d124d6fa76eaad75520.png

### m3-6bfb149151f58d124d6fa76eaad75520.png

### m4-6bfb149151f58d124d6fa76eaad75520.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-6bfb149151f58d124d6fa76eaad75520.png  PLTE not allowed in grayscale image
ERROR: c-m1-6bfb149151f58d124d6fa76eaad75520.png
OK: c-m4-6bfb149151f58d124d6fa76eaad75520.png (16x16, 1-bit palette, non-interlaced, -750.0%).
m1-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk IHDR (computed 3788c2cc, expected 254b4f22)
m1-6bfb149151f58d124d6fa76eaad75520.png  PLTE not allowed in grayscale image
m1-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk IDAT (computed 165f63a5, expected 3faa858e)
m1-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk tEXt (computed 344d4d5b, expected dc930890)
m1-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk tEXt (computed 3a7a44ce, expected 83227ea4)
m1-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk IEND (computed ae426082, expected ae8d6082)
ERROR: m1-6bfb149151f58d124d6fa76eaad75520.png
m2-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m2-6bfb149151f58d124d6fa76eaad75520.png  illegal (unless recently approved) unknown, public chunk oHDR
m2-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m2-6bfb149151f58d124d6fa76eaad75520.png  illegal reserved-bit-set chunk ubzC
m2-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m2-6bfb149151f58d124d6fa76eaad75520.png  illegal (unless recently approved) unknown, public chunk mLTE
m2-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m2-6bfb149151f58d124d6fa76eaad75520.png:  invalid chunk name "-07T" (2d 30 37 54)
m2-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m2-6bfb149151f58d124d6fa76eaad75520.png  EOF while reading -07T data
ERROR: m2-6bfb149151f58d124d6fa76eaad75520.png
m3-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m3-6bfb149151f58d124d6fa76eaad75520.png  illegal (unless recently approved) unknown, public chunk tHDR
m3-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m3-6bfb149151f58d124d6fa76eaad75520.png  illegal reserved-bit-set chunk ubzC
m3-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m3-6bfb149151f58d124d6fa76eaad75520.png  PLTE not allowed in INVALID image
m3-6bfb149151f58d124d6fa76eaad75520.png  first chunk must be IHDR
m3-6bfb149151f58d124d6fa76eaad75520.png  EOF while reading pHYs data
ERROR: m3-6bfb149151f58d124d6fa76eaad75520.png
m4-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk IHDR (computed 253d6d22, expected 253d4f22)
m4-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk tEXt (computed 344d4d5b, expected dc930890)
m4-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk tEXt (computed 3ff9cdcd, expected 83227ea4)
m4-6bfb149151f58d124d6fa76eaad75520.png  CRC error in chunk IEND (computed ae426082, expected ae8d6082)
ERROR: m4-6bfb149151f58d124d6fa76eaad75520.png
Errors were detected in 5 of the 6 files tested.
No errors were detected in 1 of the 6 files tested.

```
### 6c853ed9dacd5716bc54eb59cec30889.png

  * Origin: {{{http://i187.photobucket.com/albums/x34/lcjhfrank/BLOG/04fang230.png}}}

#### Notes

```
OK: 6c853ed9dacd5716bc54eb59cec30889.png (724x1024, 48-bit RGB, non-interlaced, 35.6%).

```
### c-m1-6e3914f26bcc8f9d004ffeac71656c01.png

### m1-6e3914f26bcc8f9d004ffeac71656c01.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-6e3914f26bcc8f9d004ffeac71656c01.png  bKGD index (17) falls outside PLTE (16)
c-m1-6e3914f26bcc8f9d004ffeac71656c01.png  private (invalid?) IDAT row-filter type (136) (warning)
c-m1-6e3914f26bcc8f9d004ffeac71656c01.png  private (invalid?) IDAT row-filter type (238) (warning)
ERROR: c-m1-6e3914f26bcc8f9d004ffeac71656c01.png
m1-6e3914f26bcc8f9d004ffeac71656c01.png  CRC error in chunk IHDR (computed 1610b7ef, expected 61178779)
m1-6e3914f26bcc8f9d004ffeac71656c01.png  bKGD index (17) falls outside PLTE (16)
m1-6e3914f26bcc8f9d004ffeac71656c01.png  private (invalid?) IDAT row-filter type (136) (warning)
m1-6e3914f26bcc8f9d004ffeac71656c01.png  private (invalid?) IDAT row-filter type (238) (warning)
ERROR: m1-6e3914f26bcc8f9d004ffeac71656c01.png
Errors were detected in 2 of the 2 files tested.

```
### 71714b783e01aec455b5a4a760326ccc.png

  * Origin: {{{brokensuite:iccp_after_plte.png}}}

#### Notes

```
71714b783e01aec455b5a4a760326ccc.png  iCCP must precede PLTE
ERROR: 71714b783e01aec455b5a4a760326ccc.png

```
### c-m2-71915ab0b1cc7350091ef7073a312d16.png

### m1-71915ab0b1cc7350091ef7073a312d16.png

### m2-71915ab0b1cc7350091ef7073a312d16.png

### m3-71915ab0b1cc7350091ef7073a312d16.png

  * Origin: {{{http://upload.wikimedia.org/wikipedia/commons/thumb/0/09/European_Parliament_6th_term_new.png/60px-European_Parliament_6th_term_new.png}}}

#### Notes

```
c-m2-71915ab0b1cc7350091ef7073a312d16.png  zlib: inflate error = -3 (data error)
c-m2-71915ab0b1cc7350091ef7073a312d16.png  zTXt keyword has control character(s) (138)
ERROR: c-m2-71915ab0b1cc7350091ef7073a312d16.png
m1-71915ab0b1cc7350091ef7073a312d16.png  first chunk must be IHDR
m1-71915ab0b1cc7350091ef7073a312d16.png  illegal (unless recently approved) unknown, public chunk vHDR
m1-71915ab0b1cc7350091ef7073a312d16.png  first chunk must be IHDR
m1-71915ab0b1cc7350091ef7073a312d16.png  invalid zTXt compression method (99)
m1-71915ab0b1cc7350091ef7073a312d16.png  first chunk must be IHDR
m1-71915ab0b1cc7350091ef7073a312d16.png  EOF while reading ight data
ERROR: m1-71915ab0b1cc7350091ef7073a312d16.png
m2-71915ab0b1cc7350091ef7073a312d16.png  CRC error in chunk cHRM (computed 9cba513c, expected 9cba51d3)
m2-71915ab0b1cc7350091ef7073a312d16.png  CRC error in chunk vpAg (computed c1d83cff, expected c1d83c27)
m2-71915ab0b1cc7350091ef7073a312d16.png  zlib: inflate error = -3 (data error)
m2-71915ab0b1cc7350091ef7073a312d16.png  zTXt keyword has control character(s) (138)
ERROR: m2-71915ab0b1cc7350091ef7073a312d16.png
m3-71915ab0b1cc7350091ef7073a312d16.png  illegal reserved-bit-set chunk gAhA
m3-71915ab0b1cc7350091ef7073a312d16.png  zlib: inflate error = -3 (data error)
m3-71915ab0b1cc7350091ef7073a312d16.png  zTXt keyword has control character(s) (138)
ERROR: m3-71915ab0b1cc7350091ef7073a312d16.png
Errors were detected in 4 of the 4 files tested.

```
### 71dd006377602359ebd2cbe7b9eaab09.png

### c-71dd006377602359ebd2cbe7b9eaab09.png

  * Origin: {{{Unknown}}}

#### Notes

```
71dd006377602359ebd2cbe7b9eaab09.png  invalid IHDR sample depth (4) for RGB+alpha image
71dd006377602359ebd2cbe7b9eaab09.png  CRC error in chunk IHDR (computed b797a415, expected 498b65ef)
71dd006377602359ebd2cbe7b9eaab09.png  CRC error in chunk gAMA (computed 37058ae9, expected 3705cfe9)
71dd006377602359ebd2cbe7b9eaab09.png  CRC error in chunk tEXt (computed a0b8acd2, expected 66747761)
71dd006377602359ebd2cbe7b9eaab09.png  EOF while reading dobe data
ERROR: 71dd006377602359ebd2cbe7b9eaab09.png
c-71dd006377602359ebd2cbe7b9eaab09.png  invalid IHDR sample depth (4) for RGB+alpha image
c-71dd006377602359ebd2cbe7b9eaab09.png  EOF while reading dobe data
ERROR: c-71dd006377602359ebd2cbe7b9eaab09.png
Errors were detected in 2 of the 2 files tested.

```
### 743b8442c69efbc457af7376af71b44c.png

  * Origin: {{{Unknown}}}

#### Notes

```
743b8442c69efbc457af7376af71b44c.png  first chunk must be IHDR
743b8442c69efbc457af7376af71b44c.png  illegal (unless recently approved) unknown, public chunk aHDR
743b8442c69efbc457af7376af71b44c.png  first chunk must be IHDR
743b8442c69efbc457af7376af71b44c.png  invalid bKGD length
743b8442c69efbc457af7376af71b44c.png  first chunk must be IHDR
ERROR: 743b8442c69efbc457af7376af71b44c.png

```
### 7b9abb94ace0278f943a6df29d0ca652.png

  * Origin: {{{brokensuite:gama_after_plte.png}}}

#### Notes

```
7b9abb94ace0278f943a6df29d0ca652.png  gAMA must precede PLTE
ERROR: 7b9abb94ace0278f943a6df29d0ca652.png

```
### 7ce702ec69b7af26b3218d1278520bce.png

  * Origin: {{{brokensuite:private_filter_method.png}}}

#### Notes

```
7ce702ec69b7af26b3218d1278520bce.png  private (invalid?) IHDR filter method (128) (warning)
WARN: 7ce702ec69b7af26b3218d1278520bce.png (32x32, 8-bit palette, non-interlaced, -25.6%).

```
### m1-7dc9db3d3e510156c619273f8f913cbe.png

  * Origin: {{{http://www.wseip.edu.pl/images/M_images/printButton.png}}}
  * Origin: {{{http://www.bcmalta.com/images/M_images/printButton.png}}}
  * Origin: {{{http://www.tt-rotamsee.de/nw14/pics/printButton.png}}}
  * Origin: {{{http://flokkarinn.is/images/M_images/printButton.png}}}
  * Origin: {{{http://web.utm.my/wangi/images/M_images/printButton.png}}}
  * Origin: {{{http://www.sbmicro.org.br/images/M_images/printButton.png}}}
  * Origin: {{{http://www.keginvestments.com//images/M_images/printButton.png}}}
  * Origin: {{{http://www.vccn.nl/images/M_images/printButton.png}}}
  * Origin: {{{http://www.coddington.org.uk/images/M_images/printButton.png}}}
  * Origin: {{{http://space.globehosting.net/~beliu1/images/M_images/printButton.png}}}
  * Origin: {{{http://tssi.no/images/M_images/printButton.png}}}
  * Origin: {{{http://www.fragielex.nl/images/M_images/printButton.png}}}
  * Origin: {{{http://gold-elites.com.ua/images/M_images/printButton.png}}}
  * Origin: {{{http://www.fisherclub.com.ua/images/M_images/printButton.png}}}
  * Origin: {{{http://www.cyberinfo.undip.ac.id/images/M_images/printButton.png}}}
  * Origin: {{{http://www.fuu.de/images/M_images/printButton.png}}}
  * Origin: {{{http://www.dance.is/images/M_images/printButton.png}}}
  * Origin: {{{http://www.deltacad-portugal.com/main/images/M_images/printButton.png}}}
  * Origin: {{{http://www.networkimprese.it/images/M_images/printButton.png}}}
  * Origin: {{{http://www.nightspot.at/templates/fotos/images/printButton.png}}}
  * Origin: {{{http://www.vogelopvangcentrum-malderen.be/images/M_images/printButton.png}}}
  * Origin: {{{http://www.thw-obernburg.de/news/pics/printButton.png}}}
  * Origin: {{{http://www.il2mania.com/images/M_images/printButton.png}}}

#### Notes

```
m1-7dc9db3d3e510156c619273f8f913cbe.png  illegal (unless recently approved) unknown, public chunk vLTE
m1-7dc9db3d3e510156c619273f8f913cbe.png  EOF while reading tRNS data
ERROR: m1-7dc9db3d3e510156c619273f8f913cbe.png

```
### c-m1-80e163ebface8b0d2fbf9823bca02936.png

### c-m2-80e163ebface8b0d2fbf9823bca02936.png

### m1-80e163ebface8b0d2fbf9823bca02936.png

### m2-80e163ebface8b0d2fbf9823bca02936.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-80e163ebface8b0d2fbf9823bca02936.png  zlib: inflate error = -3 (data error)
c-m1-80e163ebface8b0d2fbf9823bca02936.png  illegal (unless recently approved) unknown, public chunk kEND
ERROR: c-m1-80e163ebface8b0d2fbf9823bca02936.png
c-m2-80e163ebface8b0d2fbf9823bca02936.png  invalid cHRM green point 0.3 56.961
c-m2-80e163ebface8b0d2fbf9823bca02936.png  zlib: inflate error = -3 (data error)
ERROR: c-m2-80e163ebface8b0d2fbf9823bca02936.png
m1-80e163ebface8b0d2fbf9823bca02936.png  CRC error in chunk pHYs (computed 78a53f76, expected 3aa53f76)
m1-80e163ebface8b0d2fbf9823bca02936.png  zlib: inflate error = -3 (data error)
m1-80e163ebface8b0d2fbf9823bca02936.png  illegal (unless recently approved) unknown, public chunk kEND
ERROR: m1-80e163ebface8b0d2fbf9823bca02936.png
m2-80e163ebface8b0d2fbf9823bca02936.png  CRC error in chunk iCCP (computed 32f48ee5, expected fa96f15d)
m2-80e163ebface8b0d2fbf9823bca02936.png  invalid cHRM green point 0.3 56.961
m2-80e163ebface8b0d2fbf9823bca02936.png  CRC error in chunk cHRM (computed 0254d221, expected 925fc546)
m2-80e163ebface8b0d2fbf9823bca02936.png  zlib: inflate error = -3 (data error)
ERROR: m2-80e163ebface8b0d2fbf9823bca02936.png
Errors were detected in 4 of the 4 files tested.

```
### m1-814fcedc62fe4e43923c042ff1d6747f.png

### m2-814fcedc62fe4e43923c042ff1d6747f.png

  * Origin: {{{Unknown}}}

#### Notes

```
m1-814fcedc62fe4e43923c042ff1d6747f.png  zlib: inflate error = -3 (data error)
m1-814fcedc62fe4e43923c042ff1d6747f.png  tEXt keyword has control character(s) (10)
ERROR: m1-814fcedc62fe4e43923c042ff1d6747f.png
m2-814fcedc62fe4e43923c042ff1d6747f.png  first chunk must be IHDR
m2-814fcedc62fe4e43923c042ff1d6747f.png  illegal (unless recently approved) unknown, public chunk vHDR
m2-814fcedc62fe4e43923c042ff1d6747f.png  first chunk must be IHDR
m2-814fcedc62fe4e43923c042ff1d6747f.png  invalid pHYs length
m2-814fcedc62fe4e43923c042ff1d6747f.png  invalid chunk length (too large)
ERROR: m2-814fcedc62fe4e43923c042ff1d6747f.png
Errors were detected in 2 of the 2 files tested.

```
### 817f96555e2d683e7b12f778c4e38022.png

### c-817f96555e2d683e7b12f778c4e38022.png

  * Origin: {{{Unknown}}}

#### Notes

```
817f96555e2d683e7b12f778c4e38022.png  CRC error in chunk IHDR (computed 06d4b8a8, expected 498b65ef)
817f96555e2d683e7b12f778c4e38022.png  invalid gAMA length
817f96555e2d683e7b12f778c4e38022.png:  invalid chunk name "�b��" (ffffffda 62 fffffffc ffffffff)
817f96555e2d683e7b12f778c4e38022.png  EOF while reading �b�� data
ERROR: 817f96555e2d683e7b12f778c4e38022.png
c-817f96555e2d683e7b12f778c4e38022.png  invalid gAMA length
c-817f96555e2d683e7b12f778c4e38022.png:  invalid chunk name "�b��" (ffffffda 62 fffffffc ffffffff)
c-817f96555e2d683e7b12f778c4e38022.png  EOF while reading �b�� data
ERROR: c-817f96555e2d683e7b12f778c4e38022.png
Errors were detected in 2 of the 2 files tested.

```
### 829b05b759b2977bc3eb970ab256d867.png

  * Origin: {{{brokensuite:iccp_after_idat.png}}}

#### Notes

```
829b05b759b2977bc3eb970ab256d867.png  iCCP must precede IDAT
ERROR: 829b05b759b2977bc3eb970ab256d867.png

```
### 8711007ea5e351755a80cba913d16a32.png

  * Origin: {{{brokensuite:splt_length_mod_10.png}}}

#### Notes

```
8711007ea5e351755a80cba913d16a32.png  invalid number of sPLT entries (0.6)
ERROR: 8711007ea5e351755a80cba913d16a32.png

```
### 8905ba870cd5d3327a8310fa437aa076.png

  * Origin: {{{brokensuite:scal_floating_point.png}}}

#### Notes

```
8905ba870cd5d3327a8310fa437aa076.png  invalid character ('Q' = 0x51) in sCAL
ERROR: 8905ba870cd5d3327a8310fa437aa076.png

```
### c-m1-8f2b481b7fd9bd745e620b7c01a18df2.png

### c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png

### m1-8f2b481b7fd9bd745e620b7c01a18df2.png

### m2-8f2b481b7fd9bd745e620b7c01a18df2.png

  * Origin: {{{http://ibed-inst-de-gastroent-e-endosc-digestiv-ltda.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://centro-medico-sao-silvestre-s-c-ltda.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://amiu-casa-de-saude-e-assist-med-infantil-de-urg.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://kleber-gaspar-carvalho-da-silva.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://leticia-krause-schenato.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://ortopedistas-e-traumatologistas.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://conmedh-conv-med-hospitalares-clinica-sao-camilo.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}
  * Origin: {{{http://hgu-centro-hospitalar-sao-francisco.catalogo.med.br/_res/Element_hbPortal/Page_itn_mn_3.png}}}

#### Notes

```
c-m1-8f2b481b7fd9bd745e620b7c01a18df2.png  tEXt keyword is longer than 79 characters
c-m1-8f2b481b7fd9bd745e620b7c01a18df2.png  illegal (unless recently approved) unknown, public chunk wEND
ERROR: c-m1-8f2b481b7fd9bd745e620b7c01a18df2.png
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid sBIT length
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid pHYs unit specifier (186)
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  tEXt text contains NULL character(s)
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (206) (warning)
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (212) (warning)
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (206) (warning)
c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid IDAT row-filter type (40)
ERROR: c-m2-8f2b481b7fd9bd745e620b7c01a18df2.png
m1-8f2b481b7fd9bd745e620b7c01a18df2.png  tEXt keyword is longer than 79 characters
m1-8f2b481b7fd9bd745e620b7c01a18df2.png  CRC error in chunk tEXt (computed 53f53b16, expected eede1190)
m1-8f2b481b7fd9bd745e620b7c01a18df2.png  illegal (unless recently approved) unknown, public chunk wEND
ERROR: m1-8f2b481b7fd9bd745e620b7c01a18df2.png
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  CRC error in chunk IHDR (computed 01ad28bd, expected 24c67761)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid sBIT length
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid pHYs unit specifier (186)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  tEXt text contains NULL character(s)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (206) (warning)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (212) (warning)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  private (invalid?) IDAT row-filter type (206) (warning)
m2-8f2b481b7fd9bd745e620b7c01a18df2.png  invalid IDAT row-filter type (40)
ERROR: m2-8f2b481b7fd9bd745e620b7c01a18df2.png
Errors were detected in 4 of the 4 files tested.

```
### 9032e447e32e09aef5b7de2fab42494d.png

### c-9032e447e32e09aef5b7de2fab42494d.png

  * Origin: {{{Unknown}}}

#### Notes

```
9032e447e32e09aef5b7de2fab42494d.png  multiple IHDR not allowed
9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR image type (192)
9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR sample depth (126)
9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR compression method (96)
9032e447e32e09aef5b7de2fab42494d.png  private (invalid?) IHDR filter method (199) (warning)
9032e447e32e09aef5b7de2fab42494d.png  private (invalid?) IHDR interlace method (160) (warning)
9032e447e32e09aef5b7de2fab42494d.png  CRC error in chunk IHDR (computed a8a1ae0a, expected ae426082)
9032e447e32e09aef5b7de2fab42494d.png  file doesn't end with an IEND chunk
ERROR: 9032e447e32e09aef5b7de2fab42494d.png
c-9032e447e32e09aef5b7de2fab42494d.png  multiple IHDR not allowed
c-9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR image type (192)
c-9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR sample depth (126)
c-9032e447e32e09aef5b7de2fab42494d.png  invalid IHDR compression method (96)
c-9032e447e32e09aef5b7de2fab42494d.png  private (invalid?) IHDR filter method (199) (warning)
c-9032e447e32e09aef5b7de2fab42494d.png  private (invalid?) IHDR interlace method (160) (warning)
c-9032e447e32e09aef5b7de2fab42494d.png  file doesn't end with an IEND chunk
ERROR: c-9032e447e32e09aef5b7de2fab42494d.png
Errors were detected in 2 of the 2 files tested.

```
### 93e6127b9c4e7a99459c558b81d31bc5.png

  * Origin: {{{http://a.deviantart.com/avatars/u/l/ultra-sex.png}}}

#### Notes

```
OK: 93e6127b9c4e7a99459c558b81d31bc5.png (50x50, 32-bit grayscale+alpha, interlaced, 54.1%).

```
### 94e1bdbb03c42581d8407602634636ea.png

### c-94e1bdbb03c42581d8407602634636ea.png

  * Origin: {{{Unknown}}}

#### Notes

```
94e1bdbb03c42581d8407602634636ea.png  sPLT must precede IDAT
94e1bdbb03c42581d8407602634636ea.png  CRC error in chunk sPLT (computed 04b86b3a, expected ae426082)
94e1bdbb03c42581d8407602634636ea.png  file doesn't end with an IEND chunk
ERROR: 94e1bdbb03c42581d8407602634636ea.png
c-94e1bdbb03c42581d8407602634636ea.png  sPLT must precede IDAT
c-94e1bdbb03c42581d8407602634636ea.png  file doesn't end with an IEND chunk
ERROR: c-94e1bdbb03c42581d8407602634636ea.png
Errors were detected in 2 of the 2 files tested.

```
### m1-94f94e608d647b1b433f4d0ecc21e023.png

### m2-94f94e608d647b1b433f4d0ecc21e023.png

  * Origin: {{{Unknown}}}

#### Notes

```

```
### 9540743374e1fdb273b6a6ca625eb7a3.png

  * Origin: {{{Unknown}}}

#### Notes

```
9540743374e1fdb273b6a6ca625eb7a3.png  invalid gAMA value (0.0000)
9540743374e1fdb273b6a6ca625eb7a3.png  invalid cHRM white point 42949.7 42949.7
ERROR: 9540743374e1fdb273b6a6ca625eb7a3.png

```
### c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png

### c-m4-96b70653ba3f8a83b7cfd48749bed8b1.png

### m1-96b70653ba3f8a83b7cfd48749bed8b1.png

### m2-96b70653ba3f8a83b7cfd48749bed8b1.png

### m3-96b70653ba3f8a83b7cfd48749bed8b1.png

### m4-96b70653ba3f8a83b7cfd48749bed8b1.png

  * Origin: {{{http://www-em.materials.ox.ac.uk/photos/AntalKoos.png}}}

#### Notes

```
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  iCCP not allowed with sRGB
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (250) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (243) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (248) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (253) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (5)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (248) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (238) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (248) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (243) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (6)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (231) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (14)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (5)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (11)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (10)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (245) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (236) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (24)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (8)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (249) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (239) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  private (invalid?) IDAT row-filter type (250) (warning)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (7)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (10)
c-m2-96b70653ba3f8a83b7cfd48749bed8b1.png  invalid IDAT row-filter type (6)
c-m2-96b70653ba3f

```
### 9a3e0c7b687b526987e2270541002d47.png

### c-9a3e0c7b687b526987e2270541002d47.png

### c-m1-9a3e0c7b687b526987e2270541002d47.png

### c-m2-9a3e0c7b687b526987e2270541002d47.png

### m1-9a3e0c7b687b526987e2270541002d47.png

### m2-9a3e0c7b687b526987e2270541002d47.png

### m3-9a3e0c7b687b526987e2270541002d47.png

  * Origin: {{{Unknown}}}

#### Notes

```
9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (255) (warning)
9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (21)
9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk IDAT (computed 1c41dcde, expected 81be9b02)
9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk zTXt (computed a6ccd434, expected 98310798)
9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (120)
9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk zTXt (computed 5fc2f3c2, expected 5f3947e2)
9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTot
9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk zTXE
ERROR: 9a3e0c7b687b526987e2270541002d47.png
c-9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (255) (warning)
c-9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (21)
c-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (120)
c-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTot
c-9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk zTXE
ERROR: c-9a3e0c7b687b526987e2270541002d47.png
c-m1-9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (22)
c-m1-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTlt
c-m1-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (58)
c-m1-9a3e0c7b687b526987e2270541002d47.png:  invalid chunk name "pe�" (70 65 ffffffc1 00)
c-m1-9a3e0c7b687b526987e2270541002d47.png  EOF while reading pe� data
ERROR: c-m1-9a3e0c7b687b526987e2270541002d47.png
c-m2-9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (190) (warning)
c-m2-9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (40)
c-m2-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (120)
c-m2-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTot
c-m2-9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk zTXE
c-m2-9a3e0c7b687b526987e2270541002d47.png  EOF while reading IEND data
ERROR: c-m2-9a3e0c7b687b526987e2270541002d47.png
m1-9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (22)
m1-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk IDAT (computed 859e8018, expected 81be9b02)
m1-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk zTXt (computed 7ae72cac, expected 98310798)
m1-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTlt
m1-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (58)
m1-9a3e0c7b687b526987e2270541002d47.png:  invalid chunk name "pe�" (70 65 ffffffc1 00)
m1-9a3e0c7b687b526987e2270541002d47.png  EOF while reading pe� data
ERROR: m1-9a3e0c7b687b526987e2270541002d47.png
m2-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk IHDR (computed 6860fccf, expected 1f67cc59)
m2-9a3e0c7b687b526987e2270541002d47.png  private (invalid?) IDAT row-filter type (190) (warning)
m2-9a3e0c7b687b526987e2270541002d47.png  invalid IDAT row-filter type (40)
m2-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk IDAT (computed 79a48244, expected 81be9b02)
m2-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk zTXt (computed 45f6d3b9, expected 98310798)
m2-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (120)
m2-9a3e0c7b687b526987e2270541002d47.png  CRC error in chunk zTXt (computed 5fc2f3c2, expected 5f3947e2)
m2-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTot
m2-9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk zTXE
m2-9a3e0c7b687b526987e2270541002d47.png  EOF while reading IEND data
ERROR: m2-9a3e0c7b687b526987e2270541002d47.png
m3-9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk uDAT
m3-9a3e0c7b687b526987e2270541002d47.png  invalid zTXt compression method (120)
m3-9a3e0c7b687b526987e2270541002d47.png  illegal reserved-bit-set chunk zTot
m3-9a3e0c7b687b526987e2270541002d47.png  illegal (unless recently approved) unknown, public chunk zTXE
m3-9a3e0c7b687b526987e2270541002d47.png  no IDAT chunks
ERROR: m3-9a3e0c7b687b526987e2270541002d47.png
Errors were detected in 7 of the 7 files tested.

```
### 9bd8a9ed81c5a9190f74496197da7249.png

  * Origin: {{{brokensuite:multiple_time.png}}}

#### Notes

```
9bd8a9ed81c5a9190f74496197da7249.png  multiple tIME not allowed
ERROR: 9bd8a9ed81c5a9190f74496197da7249.png

```
### m1-9bec9d0461c0ef0f5faf16d0d4bdcc13.png

  * Origin: {{{http://img237.imageshack.us/img237/4148/verrohhhhla5.png}}}

#### Notes

```

```
### m1-9eb5b67f01da30f0e16062004c343e4a.png

  * Origin: {{{Unknown}}}

#### Notes

```
m1-9eb5b67f01da30f0e16062004c343e4a.png  invalid tRNS length for RGB image
m1-9eb5b67f01da30f0e16062004c343e4a.png  zlib: inflate error = -3 (data error)
ERROR: m1-9eb5b67f01da30f0e16062004c343e4a.png

```
### a1d1aafb5bca660229f8e9fc65291eab.png

  * Origin: {{{brokensuite:private_compression_method.png}}}

#### Notes

```
a1d1aafb5bca660229f8e9fc65291eab.png  private (invalid?) IHDR compression method (128) (warning)
WARN: a1d1aafb5bca660229f8e9fc65291eab.png (32x32, 8-bit palette, non-interlaced, -25.6%).

```
### a1d54c960686558901e320a52a967158.png

  * Origin: {{{brokensuite:multiple_hist.png}}}

#### Notes

```
a1d54c960686558901e320a52a967158.png  multiple hIST not allowed
ERROR: a1d54c960686558901e320a52a967158.png

```
### c-m2-a1f9d85a8243b884d40e74f656c55e75.png

### m1-a1f9d85a8243b884d40e74f656c55e75.png

### m2-a1f9d85a8243b884d40e74f656c55e75.png

  * Origin: {{{http://cgi.members.interq.or.jp/blues/zetigoya/image/sd_em19.png}}}

#### Notes

```
c-m2-a1f9d85a8243b884d40e74f656c55e75.png  invalid IDAT row-filter type (17)
c-m2-a1f9d85a8243b884d40e74f656c55e75.png  illegal (unless recently approved) unknown, public chunk tEND
ERROR: c-m2-a1f9d85a8243b884d40e74f656c55e75.png
m1-a1f9d85a8243b884d40e74f656c55e75.png  illegal (unless recently approved) unknown, public chunk uLTE
m1-a1f9d85a8243b884d40e74f656c55e75.png  tRNS must follow PLTE
m1-a1f9d85a8243b884d40e74f656c55e75.png:  invalid chunk name "tEX" (15 74 45 58)
m1-a1f9d85a8243b884d40e74f656c55e75.png  EOF while reading tEX data
ERROR: m1-a1f9d85a8243b884d40e74f656c55e75.png
m2-a1f9d85a8243b884d40e74f656c55e75.png  CRC error in chunk IHDR (computed 19d6d7a7, expected 6ed1e731)
m2-a1f9d85a8243b884d40e74f656c55e75.png  CRC error in chunk tEXt (computed be818c22, expected 8a6acd3f)
m2-a1f9d85a8243b884d40e74f656c55e75.png  invalid IDAT row-filter type (17)
m2-a1f9d85a8243b884d40e74f656c55e75.png  CRC error in chunk IDAT (computed 4bd3cd55, expected a01f3816)
m2-a1f9d85a8243b884d40e74f656c55e75.png  illegal (unless recently approved) unknown, public chunk tEND
ERROR: m2-a1f9d85a8243b884d40e74f656c55e75.png
Errors were detected in 3 of the 3 files tested.

```
### a24a39e69554a701412b3ed0c009e7f6.png

  * Origin: {{{brokensuite:multiple_chrm.png}}}

#### Notes

```
a24a39e69554a701412b3ed0c009e7f6.png  multiple cHRM not allowed
ERROR: a24a39e69554a701412b3ed0c009e7f6.png

```
### c-m2-a46ce91d8975a017917156b8824f936e.png

### c-m3-a46ce91d8975a017917156b8824f936e.png

### c-m4-a46ce91d8975a017917156b8824f936e.png

### c-m5-a46ce91d8975a017917156b8824f936e.png

### c-m6-a46ce91d8975a017917156b8824f936e.png

### c-m7-a46ce91d8975a017917156b8824f936e.png

### c-m8-a46ce91d8975a017917156b8824f936e.png

### m1-a46ce91d8975a017917156b8824f936e.png

### m2-a46ce91d8975a017917156b8824f936e.png

### m3-a46ce91d8975a017917156b8824f936e.png

### m4-a46ce91d8975a017917156b8824f936e.png

### m5-a46ce91d8975a017917156b8824f936e.png

### m6-a46ce91d8975a017917156b8824f936e.png

### m7-a46ce91d8975a017917156b8824f936e.png

### m8-a46ce91d8975a017917156b8824f936e.png

  * Origin: {{{http://www.dif.pref.tochigi.lg.jp/images/index0823.png}}}

#### Notes

```
c-m2-a46ce91d8975a017917156b8824f936e.png  invalid cHRM white point 0.31269 103.221
c-m2-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 1-bit image
c-m2-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: c-m2-a46ce91d8975a017917156b8824f936e.png
c-m3-a46ce91d8975a017917156b8824f936e.png  invalid cHRM white point 0.31269 8724.48
c-m3-a46ce91d8975a017917156b8824f936e.png  illegal (unless recently approved) unknown, public chunk jLTE
c-m3-a46ce91d8975a017917156b8824f936e.png  IDAT must follow PLTE in palette image
c-m3-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: c-m3-a46ce91d8975a017917156b8824f936e.png
c-m4-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (293)
c-m4-a46ce91d8975a017917156b8824f936e.png:  invalid chunk name "m�<%" (6d ffffffc0 3c 25)
c-m4-a46ce91d8975a017917156b8824f936e.png  EOF while reading m�<% data
ERROR: c-m4-a46ce91d8975a017917156b8824f936e.png
c-m5-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk cHRM (computed 925fc546, expected 925f0a46)
c-m5-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 1-bit image
c-m5-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
c-m5-a46ce91d8975a017917156b8824f936e.png  illegal (unless recently approved) unknown, public chunk IQND
ERROR: c-m5-a46ce91d8975a017917156b8824f936e.png
c-m6-a46ce91d8975a017917156b8824f936e.png  invalid tIME hour (57)
c-m6-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = 2 (unknown)
ERROR: c-m6-a46ce91d8975a017917156b8824f936e.png
c-m7-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 4-bit image
c-m7-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
c-m7-a46ce91d8975a017917156b8824f936e.png  EOF while reading IEND data
ERROR: c-m7-a46ce91d8975a017917156b8824f936e.png
c-m8-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 2-bit image
c-m8-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: c-m8-a46ce91d8975a017917156b8824f936e.png
m1-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: m1-a46ce91d8975a017917156b8824f936e.png
m2-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk IHDR (computed 74ad9407, expected 79bdf676)
m2-a46ce91d8975a017917156b8824f936e.png  invalid cHRM white point 0.31269 103.221
m2-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk cHRM (computed 9f5298f6, expected 925fc546)
m2-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 1-bit image
m2-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed dce1e344, expected 30a7a68a)
m2-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: m2-a46ce91d8975a017917156b8824f936e.png
m3-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk IHDR (computed bc4d1b77, expected 79bdf676)
m3-a46ce91d8975a017917156b8824f936e.png  invalid cHRM white point 0.31269 8724.48
m3-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk cHRM (computed b9684342, expected 925fc546)
m3-a46ce91d8975a017917156b8824f936e.png  illegal (unless recently approved) unknown, public chunk jLTE
m3-a46ce91d8975a017917156b8824f936e.png  IDAT must follow PLTE in palette image
m3-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: m3-a46ce91d8975a017917156b8824f936e.png
m4-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (293)
m4-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed 702a2aba, expected 9c9d48a6)
m4-a46ce91d8975a017917156b8824f936e.png:  invalid chunk name "m�<%" (6d ffffffc0 3c 25)
m4-a46ce91d8975a017917156b8824f936e.png  EOF while reading m�<% data
ERROR: m4-a46ce91d8975a017917156b8824f936e.png
m5-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk IHDR (computed 74ad9407, expected 79bdf676)
m5-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk cHRM (computed 925fc546, expected 925f0a46)
m5-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 1-bit image
m5-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed a692a17f, expected 30a7a68a)
m5-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
m5-a46ce91d8975a017917156b8824f936e.png  illegal (unless recently approved) unknown, public chunk IQND
ERROR: m5-a46ce91d8975a017917156b8824f936e.png
m6-a46ce91d8975a017917156b8824f936e.png  invalid tIME hour (57)
m6-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk tIME (computed aabc53ed, expected 1182599c)
m6-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk tEXt (computed 66adc021, expected 7185a4e1)
m6-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk cHRM (computed d5736632, expected 925fc546)
m6-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed c436d4d4, expected 30a7a68a)
m6-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk pHYs (computed df1d0254, expected 009a9c18)
m6-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = 2 (unknown)
ERROR: m6-a46ce91d8975a017917156b8824f936e.png
m7-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk IHDR (computed bc4d1b77, expected 79bdf676)
m7-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 4-bit image
m7-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed dce1e344, expected 30a7a68a)
m7-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
m7-a46ce91d8975a017917156b8824f936e.png  EOF while reading IEND data
ERROR: m7-a46ce91d8975a017917156b8824f936e.png
m8-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk IHDR (computed 330deed7, expected 79bdf676)
m8-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk tEXt (computed e6fcb7d3, expected 7185a4e1)
m8-a46ce91d8975a017917156b8824f936e.png  invalid number of PLTE entries (256) for 2-bit image
m8-a46ce91d8975a017917156b8824f936e.png  CRC error in chunk PLTE (computed 70cec9d7, expected 30a7a68a)
m8-a46ce91d8975a017917156b8824f936e.png  zlib: inflate error = -3 (data error)
ERROR: m8-a46ce91d8975a017917156b8824f936e.png
Errors were detected in 15 of the 15 files tested.

```
### c-m1-a4842373fc20cc42b8e023a329761915.png

### c-m2-a4842373fc20cc42b8e023a329761915.png

### m1-a4842373fc20cc42b8e023a329761915.png

### m2-a4842373fc20cc42b8e023a329761915.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-a4842373fc20cc42b8e023a329761915.png  invalid sBIT length
c-m1-a4842373fc20cc42b8e023a329761915.png  illegal (unless recently approved) unknown, public chunk aLTE
c-m1-a4842373fc20cc42b8e023a329761915.png  hIST must follow PLTE
c-m1-a4842373fc20cc42b8e023a329761915.png  illegal critical, safe-to-copy chunk IENc
ERROR: c-m1-a4842373fc20cc42b8e023a329761915.png
c-m2-a4842373fc20cc42b8e023a329761915.png  invalid sBIT length
c-m2-a4842373fc20cc42b8e023a329761915.png  PLTE not allowed in grayscale image
c-m2-a4842373fc20cc42b8e023a329761915.png:  invalid chunk name "" (00 60 00 20)
c-m2-a4842373fc20cc42b8e023a329761915.png  EOF while reading  data
ERROR: c-m2-a4842373fc20cc42b8e023a329761915.png
m1-a4842373fc20cc42b8e023a329761915.png  CRC error in chunk IHDR (computed 93e1c829, expected 815467c7)
m1-a4842373fc20cc42b8e023a329761915.png  invalid sBIT length
m1-a4842373fc20cc42b8e023a329761915.png  illegal (unless recently approved) unknown, public chunk aLTE
m1-a4842373fc20cc42b8e023a329761915.png  hIST must follow PLTE
m1-a4842373fc20cc42b8e023a329761915.png  illegal critical, safe-to-copy chunk IENc
ERROR: m1-a4842373fc20cc42b8e023a329761915.png
m2-a4842373fc20cc42b8e023a329761915.png  CRC error in chunk IHDR (computed 93e1c829, expected 815467c7)
m2-a4842373fc20cc42b8e023a329761915.png  invalid sBIT length
m2-a4842373fc20cc42b8e023a329761915.png  PLTE not allowed in grayscale image
m2-a4842373fc20cc42b8e023a329761915.png:  invalid chunk name "" (00 60 00 20)
m2-a4842373fc20cc42b8e023a329761915.png  EOF while reading  data
ERROR: m2-a4842373fc20cc42b8e023a329761915.png
Errors were detected in 4 of the 4 files tested.

```
### ac6343a98f8edabfcc6e536dd75aacb0.png

  * Origin: {{{http://img516.imageshack.us/img516/5884/joker1xj9.png}}}

#### Notes

```
OK: ac6343a98f8edabfcc6e536dd75aacb0.png (75x74, 8-bit palette+trns, interlaced, -58.5%).

```
### c-m1-aded9dc1dc9361363ad0b426c2ff1846.png

### m1-aded9dc1dc9361363ad0b426c2ff1846.png

  * Origin: {{{http://www.hkb.bfh.ch/typo3temp/pics/9bcf3ae114.png}}}

#### Notes

```
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (224) (warning)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (5)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (239) (warning)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (31)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (23)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  zlib: inflate error = -3 (data error)
c-m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid zTXt compression method (120)
ERROR: c-m1-aded9dc1dc9361363ad0b426c2ff1846.png
m1-aded9dc1dc9361363ad0b426c2ff1846.png  CRC error in chunk IHDR (computed dd4d2ee5, expected ddfa2ee5)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  CRC error in chunk iCCP (computed ccfced7d, expected 256333a2)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (224) (warning)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (5)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (239) (warning)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (31)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid IDAT row-filter type (23)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  CRC error in chunk IDAT (computed 2a61b8b5, expected a796c5bb)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  zlib: inflate error = -3 (data error)
m1-aded9dc1dc9361363ad0b426c2ff1846.png  invalid zTXt compression method (120)
ERROR: m1-aded9dc1dc9361363ad0b426c2ff1846.png
Errors were detected in 2 of the 2 files tested.

```
### affc57dfffa5ec448a0795738d456018.png

  * Origin: {{{http://images.mygirlyspace.com/myspacegraphics/images/graphics/prod_659_34483.png}}}

#### Notes

```
OK: affc57dfffa5ec448a0795738d456018.png (435x235, 8-bit palette+trns, non-interlaced, 91.5%).

```
### b3ac9fdb7239f42c734921dfe790291b.png

  * Origin: {{{brokensuite:chrm_after_plte.png}}}

#### Notes

```
b3ac9fdb7239f42c734921dfe790291b.png  cHRM must precede PLTE
ERROR: b3ac9fdb7239f42c734921dfe790291b.png

```
### b583e48e218193e4c287f033931a6314.png

  * Origin: {{{Unknown}}}

#### Notes

```
b583e48e218193e4c287f033931a6314.png  invalid number of PLTE entries (0)
ERROR: b583e48e218193e4c287f033931a6314.png

```
### b59d7a023a8dcd112da2eb859004199a.png

  * Origin: {{{http://ruph.sopca.com/wp-content/uploads/arabic-ads-facebook1.png}}}

#### Notes

```
OK: b59d7a023a8dcd112da2eb859004199a.png (470x551, 32-bit RGB+alpha, non-interlaced, 96.8%).

```
### c-m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png

### m1-b68163a6a8e2ccf3c8ad2c70a26c1150.png

### m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png

### m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk aDAT
c-m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png:  invalid chunk name "I�D" (49 1e ffffffba 44)
c-m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png  EOF while reading I�D data
ERROR: c-m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png
m1-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk aDAT
m1-b68163a6a8e2ccf3c8ad2c70a26c1150.png:  invalid chunk name "@END" (40 45 4e 44)
m1-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk @END
ERROR: m1-b68163a6a8e2ccf3c8ad2c70a26c1150.png
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk jHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk oFFU
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk pHYY
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk aDAT
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png:  invalid chunk name "IE�D" (49 45 ffffffba 44)
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  first chunk must be IHDR
m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png  EOF while reading IE�D data
ERROR: m2-b68163a6a8e2ccf3c8ad2c70a26c1150.png
m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png  CRC error in chunk vpAg (computed f790b292, expected 09c59193)
m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png  illegal (unless recently approved) unknown, public chunk aDAT
m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png:  invalid chunk name "I�D" (49 1e ffffffba 44)
m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png  EOF while reading I�D data
ERROR: m3-b68163a6a8e2ccf3c8ad2c70a26c1150.png
Errors were detected in 4 of the 4 files tested.

```
### c-m1-b977e74d9de1f6689fdd84c4e38830f5.png

### c-m2-b977e74d9de1f6689fdd84c4e38830f5.png

### m1-b977e74d9de1f6689fdd84c4e38830f5.png

### m2-b977e74d9de1f6689fdd84c4e38830f5.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (249) (warning)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (13)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (216) (warning)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (43)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (236) (warning)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (150) (warning)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (35)
c-m1-b977e74d9de1f6689fdd84c4e38830f5.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-b977e74d9de1f6689fdd84c4e38830f5.png
c-m2-b977e74d9de1f6689fdd84c4e38830f5.png  invalid zTXt compression method (13)
c-m2-b977e74d9de1f6689fdd84c4e38830f5.png  zTXt keyword has control character(s) (26)
c-m2-b977e74d9de1f6689fdd84c4e38830f5.png  zlib: inflate error = -3 (data error)
c-m2-b977e74d9de1f6689fdd84c4e38830f5.png  invalid chunk length (too large)
ERROR: c-m2-b977e74d9de1f6689fdd84c4e38830f5.png
m1-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk IDAT (computed 1b3e1a53, expected 941ff572)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (249) (warning)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (13)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (216) (warning)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (43)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (236) (warning)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  private (invalid?) IDAT row-filter type (150) (warning)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  invalid IDAT row-filter type (35)
m1-b977e74d9de1f6689fdd84c4e38830f5.png  zlib: inflate error = -3 (data error)
ERROR: m1-b977e74d9de1f6689fdd84c4e38830f5.png
m2-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk iCCP (computed 39b8032f, expected fcb2b1ed)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk pHYs (computed b81a8e3f, expected d2dd7efc)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  invalid zTXt compression method (13)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk zTXt (computed 9c724d55, expected 4c86832d)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk tEXt (computed d2166d05, expected ce38b7f9)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  zTXt keyword has control character(s) (26)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  CRC error in chunk zTXt (computed bf657e16, expected 8a471546)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  zlib: inflate error = -3 (data error)
m2-b977e74d9de1f6689fdd84c4e38830f5.png  invalid chunk length (too large)
ERROR: m2-b977e74d9de1f6689fdd84c4e38830f5.png
Errors were detected in 4 of the 4 files tested.

```
### ba2b2b6e72ca0e4683bb640e2d5572f8.png

  * Origin: {{{http://www.dicts.info/img/ud/shirt.png}}}

#### Notes

```
OK: ba2b2b6e72ca0e4683bb640e2d5572f8.png (218x265, 32-bit RGB+alpha, non-interlaced, 83.2%).

```
### bd927c8547634cdbdd22af0afe818a9b.png

  * Origin: {{{Unknown}}}

#### Notes

```

```
### bf203e765c98b12f6c2b2c33577c730d.png

  * Origin: {{{brokensuite:offs_after_idat.png}}}

#### Notes

```
bf203e765c98b12f6c2b2c33577c730d.png  pCAL must precede IDAT
bf203e765c98b12f6c2b2c33577c730d.png  sCAL must precede IDAT
bf203e765c98b12f6c2b2c33577c730d.png  pHYs must precede IDAT
bf203e765c98b12f6c2b2c33577c730d.png  oFFs must precede IDAT
ERROR: bf203e765c98b12f6c2b2c33577c730d.png

```
### c-m1-bfce28c0e44bc8d1824d48fbec5075e2.png

### m1-bfce28c0e44bc8d1824d48fbec5075e2.png

  * Origin: {{{http://static.todoexpertos.com/fotos/48x48/mariplus23_Identicon.png}}}

#### Notes

```
c-m1-bfce28c0e44bc8d1824d48fbec5075e2.png  invalid cHRM white point 39594.5 0.329
c-m1-bfce28c0e44bc8d1824d48fbec5075e2.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-bfce28c0e44bc8d1824d48fbec5075e2.png
m1-bfce28c0e44bc8d1824d48fbec5075e2.png  CRC error in chunk gAMA (computed 22000143, expected 60fc6105)
m1-bfce28c0e44bc8d1824d48fbec5075e2.png  invalid cHRM white point 39594.5 0.329
m1-bfce28c0e44bc8d1824d48fbec5075e2.png  CRC error in chunk cHRM (computed ba8c0244, expected 9cba513c)
m1-bfce28c0e44bc8d1824d48fbec5075e2.png  zlib: inflate error = -3 (data error)
ERROR: m1-bfce28c0e44bc8d1824d48fbec5075e2.png
Errors were detected in 2 of the 2 files tested.

```
### c0a76d267196727887d45de4889bec33.png

  * Origin: {{{brokensuite:length_offs.png}}}

#### Notes

```
c0a76d267196727887d45de4889bec33.png  invalid oFFs length
ERROR: c0a76d267196727887d45de4889bec33.png

```
### c1a4baf5d7c68d366d4d4f948f7295be.png

  * Origin: {{{brokensuite:gama_after_idat.png}}}

#### Notes

```
c1a4baf5d7c68d366d4d4f948f7295be.png  gAMA must precede IDAT
ERROR: c1a4baf5d7c68d366d4d4f948f7295be.png

```
### c53911b0385c34a8204c30fdc14ea5cc.png

### c-c53911b0385c34a8204c30fdc14ea5cc.png

  * Origin: {{{Unknown}}}

#### Notes

```
c53911b0385c34a8204c30fdc14ea5cc.png  CRC error in chunk IDAT (computed 35af061e, expected ae426082)
c53911b0385c34a8204c30fdc14ea5cc.png  file doesn't end with an IEND chunk
ERROR: c53911b0385c34a8204c30fdc14ea5cc.png
c-c53911b0385c34a8204c30fdc14ea5cc.png  file doesn't end with an IEND chunk
ERROR: c-c53911b0385c34a8204c30fdc14ea5cc.png
Errors were detected in 2 of the 2 files tested.

```
### c-m1-c5a372c145ce25ce712959cd3b6df35e.png

### m1-c5a372c145ce25ce712959cd3b6df35e.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid cHRM red point 168.412 42782.2
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (233) (warning)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (213) (warning)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (243) (warning)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (20)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (236) (warning)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (66)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (32)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  zlib: inflate error = -3 (data error)
c-m1-c5a372c145ce25ce712959cd3b6df35e.png  illegal (unless recently approved) unknown, public chunk qTXt
ERROR: c-m1-c5a372c145ce25ce712959cd3b6df35e.png
m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid cHRM red point 168.412 42782.2
m1-c5a372c145ce25ce712959cd3b6df35e.png  CRC error in chunk cHRM (computed c5335f2e, expected 9cba513c)
m1-c5a372c145ce25ce712959cd3b6df35e.png  CRC error in chunk IDAT (computed 81ad4d2f, expected b8ace67b)
m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (233) (warning)
m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (213) (warning)
m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (243) (warning)
m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (20)
m1-c5a372c145ce25ce712959cd3b6df35e.png  private (invalid?) IDAT row-filter type (236) (warning)
m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (66)
m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (32)
m1-c5a372c145ce25ce712959cd3b6df35e.png  CRC error in chunk IDAT (computed 5b00d204, expected f72e2fc4)
m1-c5a372c145ce25ce712959cd3b6df35e.png  invalid IDAT row-filter type (32)
m1-c5a372c145ce25ce712959cd3b6df35e.png  zlib: inflate error = -3 (data error)
m1-c5a372c145ce25ce712959cd3b6df35e.png  illegal (unless recently approved) unknown, public chunk qTXt
ERROR: m1-c5a372c145ce25ce712959cd3b6df35e.png
Errors were detected in 2 of the 2 files tested.

```
### c5c030bf52b9b2d8c45c88988fafff4f.png

  * Origin: {{{brokensuite:bkgd_after_idat.png}}}

#### Notes

```
c5c030bf52b9b2d8c45c88988fafff4f.png  bKGD must precede IDAT
ERROR: c5c030bf52b9b2d8c45c88988fafff4f.png

```
### c636287a4d7cb1a36362f7f236564cef.png

  * Origin: {{{brokensuite:splt_duplicate_name.png}}}

#### Notes

```
OK: c636287a4d7cb1a36362f7f236564cef.png (32x32, 8-bit palette, non-interlaced, -29.9%).

```
### m1-cb265e4ae8967567fca5b0ecd58b90cb.png

  * Origin: {{{http://moj.name/files/logo.png}}}

#### Notes

```
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  first chunk must be IHDR
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  illegal (unless recently approved) unknown, public chunk pHDR
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  first chunk must be IHDR
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  illegal (unless recently approved) unknown, public chunk bKGj
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  first chunk must be IHDR
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  invalid tIME length
m1-cb265e4ae8967567fca5b0ecd58b90cb.png:  invalid chunk name "��;" (ffffffff 7f ffffffed 3b)
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  first chunk must be IHDR
m1-cb265e4ae8967567fca5b0ecd58b90cb.png  EOF while reading ��; data
ERROR: m1-cb265e4ae8967567fca5b0ecd58b90cb.png

```
### d2e515cfdabae699301dcf290382474d.png

  * Origin: {{{http://crohncolitis.foroactivo.com/users/40/21/63/avatars/30-41.png}}}

#### Notes

```
OK: d2e515cfdabae699301dcf290382474d.png (120x126, 32-bit RGB+alpha, non-interlaced, -81.2%).

```
### c-d3ffec5786387c590721e674d705f16e.png

### d3ffec5786387c590721e674d705f16e.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-d3ffec5786387c590721e674d705f16e.png  invalid IDAT row-filter type (112)
c-d3ffec5786387c590721e674d705f16e.png  illegal (unless recently approved) unknown, public chunk aEND
ERROR: c-d3ffec5786387c590721e674d705f16e.png
d3ffec5786387c590721e674d705f16e.png  CRC error in chunk IHDR (computed 51ed9ceb, expected 6e096d3c)
d3ffec5786387c590721e674d705f16e.png  invalid IDAT row-filter type (112)
d3ffec5786387c590721e674d705f16e.png  illegal (unless recently approved) unknown, public chunk aEND
ERROR: d3ffec5786387c590721e674d705f16e.png
Errors were detected in 2 of the 2 files tested.

```
### d45b0dbbb808df6486f8a13ea44ea174.png

  * Origin: {{{brokensuite:offs_unit_specifier.png}}}

#### Notes

```
d45b0dbbb808df6486f8a13ea44ea174.png  invalid oFFs unit specifier (2)
ERROR: d45b0dbbb808df6486f8a13ea44ea174.png

```
### m1-d4b25a2b8b5fcec0a3e284579d539f35.png

  * Origin: {{{Unknown}}}

#### Notes

```
m1-d4b25a2b8b5fcec0a3e284579d539f35.png  illegal (unless recently approved) unknown, public chunk fAMA
m1-d4b25a2b8b5fcec0a3e284579d539f35.png  zlib: inflate error = -3 (data error)
m1-d4b25a2b8b5fcec0a3e284579d539f35.png  cHRM must precede PLTE
ERROR: m1-d4b25a2b8b5fcec0a3e284579d539f35.png

```
### c-m1-d87a07bdc461bf81e43447ca0620d71d.png

### m1-d87a07bdc461bf81e43447ca0620d71d.png

### m2-d87a07bdc461bf81e43447ca0620d71d.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (238) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (250) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (251) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (5)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (252) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (60)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (108)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (186) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (208) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (8)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (137) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (117)
c-m1-d87a07bdc461bf81e43447ca0620d71d.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-d87a07bdc461bf81e43447ca0620d71d.png
m1-d87a07bdc461bf81e43447ca0620d71d.png  CRC error in chunk IDAT (computed 8ce08b76, expected d61f6723)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (251) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (238) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (250) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (251) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (5)
m1-d87a07bdc461bf81e43447ca0620d71d.png  CRC error in chunk IDAT (computed 53a6db55, expected f400847a)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (252) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (60)
m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (108)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (186) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (208) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (255) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (8)
m1-d87a07bdc461bf81e43447ca0620d71d.png  CRC error in chunk IDAT (computed 5089eb97, expected 3f12925d)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (137) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  private (invalid?) IDAT row-filter type (254) (warning)
m1-d87a07bdc461bf81e43447ca0620d71d.png  invalid IDAT row-filter type (117)
m1-d87a07bdc461bf81e43447ca0620d71d.png  zlib: inflate error = -3 (data error)
ERROR: m1-d87a07bdc461bf81e43447ca0620d71d.png
m2-d87a07bdc461bf81e43447ca0620d71d.png  first chunk must be IHDR
m2-d87a07bdc461bf81e43447ca0620d71d.png  illegal (unless recently approved) unknown, public chunk zHDR
m2-d87a07bdc461bf81e43447ca0620d71d.png  first chunk must be IHDR
m2-d87a07bdc461bf81e43447ca0620d71d.png  illegal reserved-bit-set chunk iCbP
m2-d87a07bdc461bf81e43447ca0620d71d.png  first chunk must be IHDR
m2-d87a07bdc461bf81e43447ca0620d71d.png:  invalid chunk name "vpA�" (76 70 41 ffffffdb)
m2-d87a07bdc461bf81e43447ca0620d71d.png  first chunk must be IHDR
m2-d87a07bdc461bf81e43447ca0620d71d.png  invalid chunk length (too large)
ERROR: m2-d87a07bdc461bf81e43447ca0620d71d.png
Errors were detected in 3 of the 3 files tested.

```
### d92428f3fc9c806b0a4373b54e06785e.png

  * Origin: {{{http://www.jmcraeproductions.com/Uploaded_Files/jmcraeproductions.com-Main1.png}}}

#### Notes

```
d92428f3fc9c806b0a4373b54e06785e.png  invalid tIME length
ERROR: d92428f3fc9c806b0a4373b54e06785e.png

```
### dd18aac055d531e0e4ff8979458dbaa3.png

  * Origin: {{{brokensuite:splt_length_mod_6.png}}}

#### Notes

```
dd18aac055d531e0e4ff8979458dbaa3.png  invalid number of sPLT entries (1.66667)
ERROR: dd18aac055d531e0e4ff8979458dbaa3.png

```
### c-m1-e0f25ec3373dfdca79ba7bcc3ad366f3.png

### m1-e0f25ec3373dfdca79ba7bcc3ad366f3.png

  * Origin: {{{Unknown}}}

#### Notes

```
OK: c-m1-e0f25ec3373dfdca79ba7bcc3ad366f3.png (621x174, 32-bit RGB+alpha, non-interlaced, 52.5%).
m1-e0f25ec3373dfdca79ba7bcc3ad366f3.png  CRC error in chunk zTXt (computed 8e5143e2, expected 9ced0937)
ERROR: m1-e0f25ec3373dfdca79ba7bcc3ad366f3.png
Errors were detected in 1 of the 2 files tested.
No errors were detected in 1 of the 2 files tested.

```
### m1-e275d32a37943b0d5eeb86ffb04b7cf2.png

### m2-e275d32a37943b0d5eeb86ffb04b7cf2.png

  * Origin: {{{Unknown}}}

#### Notes

```
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk aHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk pHOs
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk nDAT
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  tEXt keyword has control character(s) (143)
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m1-e275d32a37943b0d5eeb86ffb04b7cf2.png  no IDAT chunks
ERROR: m1-e275d32a37943b0d5eeb86ffb04b7cf2.png
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk aHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk oFFZ
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal reserved-bit-set chunk lHns
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  zlib: inflate error = -3 (data error)
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  illegal (unless recently approved) unknown, public chunk tEXK
m2-e275d32a37943b0d5eeb86ffb04b7cf2.png  first chunk must be IHDR
ERROR: m2-e275d32a37943b0d5eeb86ffb04b7cf2.png
Errors were detected in 2 of the 2 files tested.

```
### c-e585afb2ecf50c04eaf0dedb71602cb8.png

### e585afb2ecf50c04eaf0dedb71602cb8.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid bKGD length
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (24)
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (111)
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (115)
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (10)
c-e585afb2ecf50c04eaf0dedb71602cb8.png  private (invalid?) IDAT row-filter type (131) (warning)
c-e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (6)
ERROR: c-e585afb2ecf50c04eaf0dedb71602cb8.png
e585afb2ecf50c04eaf0dedb71602cb8.png  CRC error in chunk IHDR (computed a9b9ca49, expected 3c0171e2)
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid bKGD length
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (24)
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (111)
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (115)
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (10)
e585afb2ecf50c04eaf0dedb71602cb8.png  private (invalid?) IDAT row-filter type (131) (warning)
e585afb2ecf50c04eaf0dedb71602cb8.png  invalid IDAT row-filter type (6)
ERROR: e585afb2ecf50c04eaf0dedb71602cb8.png
Errors were detected in 2 of the 2 files tested.

```
### e59ec0cfb8ab64558099543dc19f8378.png

  * Origin: {{{http://www.cg.opstinakotor.org/templates/opstina_kotor_2007/images/i_font_large_x.png}}}

#### Notes

```
OK: e59ec0cfb8ab64558099543dc19f8378.png (18x11, 1-bit palette+trns, interlaced, -672.7%).

```
### e76546768d4a8f2f4c39339345c7614c.png

  * Origin: {{{brokensuite:length_phys.png}}}

#### Notes

```
e76546768d4a8f2f4c39339345c7614c.png  invalid pHYs length
ERROR: e76546768d4a8f2f4c39339345c7614c.png

```
### c-ea01d6c175bb25dc75757cf8a5793822.png

### ea01d6c175bb25dc75757cf8a5793822.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-ea01d6c175bb25dc75757cf8a5793822.png  private (invalid?) IHDR interlace method (130) (warning)
c-ea01d6c175bb25dc75757cf8a5793822.png  EOF while reading tEXt data
ERROR: c-ea01d6c175bb25dc75757cf8a5793822.png
ea01d6c175bb25dc75757cf8a5793822.png  private (invalid?) IHDR interlace method (130) (warning)
ea01d6c175bb25dc75757cf8a5793822.png  CRC error in chunk IHDR (computed 31086bbc, expected 498b65ef)
ea01d6c175bb25dc75757cf8a5793822.png  CRC error in chunk gAMA (computed 37058ae9, expected 1f058ae9)
ea01d6c175bb25dc75757cf8a5793822.png  EOF while reading tEXt data
ERROR: ea01d6c175bb25dc75757cf8a5793822.png
Errors were detected in 2 of the 2 files tested.

```
### ebfb1cd42314a557e72d4da75c21fc1c.png

  * Origin: {{{http://behance.vo.llnwd.net/profiles/83520/projects/135867/0835201223910993.png}}}

#### Notes

```
OK: ebfb1cd42314a557e72d4da75c21fc1c.png (202x158, 32-bit RGB+alpha, non-interlaced, 84.2%).

```
### ed5f2464fcaadd4e0a5e905e3ac41ad5.png

  * Origin: {{{brokensuite:scal_after_idat.png}}}

#### Notes

```
ed5f2464fcaadd4e0a5e905e3ac41ad5.png  pHYs must precede IDAT
ed5f2464fcaadd4e0a5e905e3ac41ad5.png  sCAL must precede IDAT
ERROR: ed5f2464fcaadd4e0a5e905e3ac41ad5.png

```
### edf5c1b0aa5b01eea5017290a286a173.png

  * Origin: {{{http://tutihoko.web.infoseek.co.jp/bro7761.png}}}

#### Notes

```
edf5c1b0aa5b01eea5017290a286a173.png  additional data after IEND chunk
edf5c1b0aa5b01eea5017290a286a173.png  EOF while reading chunk length
ERROR: edf5c1b0aa5b01eea5017290a286a173.png

```
### c-f23a99688fa66359f6186678e6b2f14a.png

### f23a99688fa66359f6186678e6b2f14a.png

  * Origin: {{{Unknown}}}

#### Notes

```
c-f23a99688fa66359f6186678e6b2f14a.png  invalid IHDR sample depth (0)
c-f23a99688fa66359f6186678e6b2f14a.png  private (invalid?) IDAT row-filter type (255) (warning)
ERROR: c-f23a99688fa66359f6186678e6b2f14a.png
f23a99688fa66359f6186678e6b2f14a.png  invalid IHDR sample depth (0)
f23a99688fa66359f6186678e6b2f14a.png  CRC error in chunk IHDR (computed 5ea996be, expected 6ed9dd7f)
f23a99688fa66359f6186678e6b2f14a.png  private (invalid?) IDAT row-filter type (255) (warning)
ERROR: f23a99688fa66359f6186678e6b2f14a.png
Errors were detected in 2 of the 2 files tested.

```
### f427b6bee1acd1fea3ec953bc556a18a.png

  * Origin: {{{brokensuite:plte_empty.png}}}

#### Notes

```
f427b6bee1acd1fea3ec953bc556a18a.png  invalid number of PLTE entries (0)
ERROR: f427b6bee1acd1fea3ec953bc556a18a.png

```
### f5e7b9db8e8d002a26304f5c81889ee1.png

  * Origin: {{{Unknown}}}

#### Notes

```
f5e7b9db8e8d002a26304f5c81889ee1.png  EOF while reading IHDR data
ERROR: f5e7b9db8e8d002a26304f5c81889ee1.png

```
### f6266c0e9c2f7db9fab0f84562f63b6c.png

  * Origin: {{{brokensuite:ster_after_idat.png}}}

#### Notes

```
f6266c0e9c2f7db9fab0f84562f63b6c.png  sTER must precede IDAT
ERROR: f6266c0e9c2f7db9fab0f84562f63b6c.png

```
### f757de9794666c3d14985210679bc98c.png

  * Origin: {{{brokensuite:multiple_phys.png}}}

#### Notes

```
f757de9794666c3d14985210679bc98c.png  multiple pHYs not allowed
ERROR: f757de9794666c3d14985210679bc98c.png

```
### f85c09bb72db5a572d24b8d3a0d56542.png

  * Origin: {{{Unknown}}}

#### Notes

```
f85c09bb72db5a572d24b8d3a0d56542.png  this is neither a PNG or JNG image nor a MNG stream
ERROR: f85c09bb72db5a572d24b8d3a0d56542.png

```
### fa9f6aa9bcc679d20e171dbf07a628fd.png

  * Origin: {{{brokensuite:multiple_gama.png}}}

#### Notes

```
fa9f6aa9bcc679d20e171dbf07a628fd.png  multiple gAMA not allowed
ERROR: fa9f6aa9bcc679d20e171dbf07a628fd.png



```
### c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png

### c-m2-fcac2d6a6a739e8ceb946ac99200d9f1.png

### m1-fcac2d6a6a739e8ceb946ac99200d9f1.png

### m2-fcac2d6a6a739e8ceb946ac99200d9f1.png

  * Origin: {{{http://www.schaik.com/pngsuite/ch1n3p04.png}}}

#### Notes

```
c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  37 sBIT blue bits invalid for 8-bit/sample image
c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  invalid number of PLTE entries (15) for 1-bit image
c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  illegal (unless recently approved) unknown, public chunk pIST
c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  zlib: inflate error = -3 (data error)
ERROR: c-m1-fcac2d6a6a739e8ceb946ac99200d9f1.png
c-m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  zlib: inflate error = -3 (data error)
c-m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  EOF while reading fEND data
ERROR: c-m2-fcac2d6a6a739e8ceb946ac99200d9f1.png
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  CRC error in chunk IHDR (computed 3eb3d821, expected 81546781)
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  CRC error in chunk gAMA (computed 31e8965f, expected 9fe8965f)
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  37 sBIT blue bits invalid for 8-bit/sample image
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  CRC error in chunk sBIT (computed 3b91a5fd, expected 77f8b5a3)
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  invalid number of PLTE entries (15) for 1-bit image
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  illegal (unless recently approved) unknown, public chunk pIST
m1-fcac2d6a6a739e8ceb946ac99200d9f1.png  zlib: inflate error = -3 (data error)
ERROR: m1-fcac2d6a6a739e8ceb946ac99200d9f1.png
m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  CRC error in chunk IHDR (computed f6535751, expected 9d5467c7)
m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  CRC error in chunk hIST (computed 44da2ff3, expected 48995941)
m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  zlib: inflate error = -3 (data error)
m2-fcac2d6a6a739e8ceb946ac99200d9f1.png  EOF while reading fEND data
ERROR: m2-fcac2d6a6a739e8ceb946ac99200d9f1.png
Errors were detected in 4 of the 4 files tested.

```
### fde6410fe7fb87f095bc855279d5beab.png

  * Origin: {{{Unknown}}}

#### Notes

```
fde6410fe7fb87f095bc855279d5beab.png:  CORRUPTED by text conversion
ERROR: fde6410fe7fb87f095bc855279d5beab.png

```