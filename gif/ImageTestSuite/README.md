# ImageTestSuite &mdash; GIF

This folder contains images from the `imagetestsuite` located at:

https://code.google.com/archive/p/imagetestsuite/

Notes from that project below.

---

# Introduction

This page contains information about the GIF files from the testsuite. Many thanks to Wolfgang Keller for his detailed notes describing the malformed files.

## 0646caeb9b9161c777f117007921a687.gif

|| Format || GIF 89a ||

### Description

At offset 0x418F we have an Image Data block (preceded by other Image Data blocks):

```
0x418F: 31 (Block Size)
        ... (0x31 bytes of Data Values)
```

Now a Block Terminator follows:

```
0x41C1: 00 (Block Terminator)
```

But after it (offset 0x41C2) we don't have another 0x00.

```
0x41C2: 00
```

This is not the beginning of a valid block according to GIF 89a specification.

Section 2 of the GIF 89a specification clearly states:

```
"The Graphics Interchange Format(sm) as specified here should be
considered complete; any deviation from it should be considered
invalid, including but not limited to,[...] the inclusion of
extraneous data within or between blocks [...]".
```

##243d9798466d64aba0acaa41f980bea6.gif
##7092f253998c1b6b869707ad7ae92854.gif

|| Format || GIF 89a ||

### Description

At offset 0x22FC we have the beginning of a Graphic Control Extension block

```
0x22FC: 0x21 (Extension Introducer)
0x22FD: 0xF9 (Graphic Control Label)
0x22FE: 0xEE (Block Size)
```

But according to the GIF 89a specification ("23. Graphic Control Extension") "[The Block Size] field contains the fixed value 4." - so these GIF files are invalid.

## 2b5bc31d84703bfb9f371925f0e3e57d.gif
## 5f09a896c191db3fa7ea6bdd5ebe9485.gif

|| Format || GIF 89a ||

### Description

At offset 0x328 we have an Image Descriptor:

```
0x328: 2C 00 00 00 00 00 00 2B 00 80 08 FC 00 FF 09 1C
```

It has no Local Color Table Flag set - so it is followed directly by a Table Based Image Data block:

```
0x338: 48 (LZW Minimum Code Size)
       ...
```

But the LZW Minimum Code Size field has to be 2 <= LZW Minimum Code Size <= 8.

## 55abb3cc464305dd554171c3d44cb61f.gif
## 9f8f6046eaf9ffa2d9c5d6db05c5f881.gif

|| Format || GIF 89a ||

### Description

The first error in these files (from offset 0x315 on) is the same as in fc3e2b992c559055267e26dc23e484c0.gif. Look there for reference.

If you decide to ignore this error, you find another one in each of these two files:

Offset 0x87A contains the Block Terminator for Image Data. Now let's look at the byte at offset 0x87B:

```
55abb3cc464305dd554171c3d44cb61f.gif:
0x87B: 2C
```

This means an Image Descriptor is the next block. Unluckily the file ends here prematurely.

```
9f8f6046eaf9ffa2d9c5d6db05c5f881.gif:
0x87B: 21
```

0x21 - an "Extension Introducer" byte. The next byte would tell which kind of Extension block follows. Unluckily the file prematurely ends here.

So obviously in both files no Trailer (0x3B) to finish the GIF file is to be found.

Note: if we changed the byte at offset 0x87B to 0x3B, these files would perhaps become valid (in the file fc3e2b992c559055267e26dc23e484c0.gif this "bugfix" - or more exactly "not introducing this error" - was applied).

## 6d939393058de0579fca1bbf10ecff25.gif

|| Format || GIF 89a ||

### Description

From offset 0x6E3F on we have

```
0x6E3F: 2C (Image Descriptor)
        00 00 (Image Left Position)
        00 00 (Image Top Position)
        A0 00 (Image Width)
        78 00 (Image Height)
        87    (Local Color Table having 256 (0x100) colors)
```

So the Local Color Table begins at offset 0x6E49 and consists of 0x300=3*0x100 bytes. But the file consists of exactly 0x7000 bytes. So we can only read 0x1B7 (< 0x300) bytes. In other words: the file ends prematurely.

## adaf0da1764aafb7039440dbe098569b.gif

|| Format || GIF 89a ||

### Description

At offset 0x12FD:

```
0x12FD: 2C (Image Descriptor)
        00 00 (Image Left Position)
        00 00 (Image Top Position)
        BD 00 (Image Width)
        71 00 (Image Width)
        84    (Local Color Table having 32 (2^(4+1)) colors)
```

From offset 0x1367 on we have Table Based Image Data

```
0x1367: 05 (LZW Minimum Code Size)
0x1368: FF (Block Size)
    0xFF bytes of Data Values follow
0x1468: FF (Block Size)
    0xFF bytes of Data Values follow
0x1568: FF (Block Size)
    0xFF bytes of Data Values follow
0x1668: FF (Block Size)
    0xFF bytes of Data Values follow
0x1768: FF (Block Size)
    0xFF bytes of Data Values follow
0x1868: FF (Block Size)
    0xFF bytes of Data Values follow
0x1968: FF (Block Size)
    0xFF bytes of Data Values follow
0x1A68: FF (Block Size)
    0xFF bytes of Data Values follow
0x1B68: FF (Block Size)
    0xFF bytes of Data Values follow
0x1C68: FF (Block Size)
    0xFF bytes of Data Values follow
0x1D68: FF (Block Size)
    0xFF bytes of Data Values follow
0x1E68: FF (Block Size)
    0xFF bytes of Data Values follow
0x1F68: FF (Block Size)
    0xFF bytes of Data Values follow
0x2068: FF (Block Size)
    0xFF bytes of Data Values follow
0x2168: FF (Block Size)
    0xFF bytes of Data Values follow
0x2268: FF (Block Size)
    0xFF bytes of Data Values follow
0x2368: FF (Block Size)
    0xFF bytes of Data Values follow
0x2468: FF (Block Size)
    0xFF bytes of Data Values follow
0x2568: FF (Block Size)
    0xFF bytes of Data Values follow
0x2668: FF (Block Size)
    0xFF bytes of Data Values follow
0x2768: FF (Block Size)
    0xFF bytes of Data Values follow
0x2868: 0E (Block Size)
    0x0E bytes of Data Values follow
0x2877: 00 (Block Terminator)
```

Here the file ends.

No Trailer (0x3B) to terminate the file follows. If we appended it, the file would perhaps be correct.

## adf6f850b13dff73ebb22862c6ab028b.gif

|| Format || GIF 89a ||

### Description

Beginning with the highest bit of the byte of offset 0x7FFFF we read a code of 11 bits:

```
code word bit count: 0xB (11)

0x7FFFF: 50 88 73 B7
01010000 10001000 01110011 10110111
0        10001000       11
```

As you can see, the code word is (binary) 11100010000, i. e. 0x710.

The problem is: at this place, the table index in the LZW code table is 0x052E. The table index always has to be larger than the current code word because of the algorithmic details of the LZW compression.

## bc7af0616c4ae99144c8600e7b39beea.gif

|| Format || GIF 89a ||

### Description

At offset 0x30D

```
0x30D: 21 F9 (Graphic Control Extension)
       04 00 E8 03 00
       00
```

Now at offset 0x315

```
0x315: 21 FF (Application Extension)
       0B 4E 45 54 53 43 41 50 45 32 2E 30
       03 01 10 27
       00

0x328: 2C (Image Descriptor)
       ...
```

According to the GIF Grammar (Appendix B. of GIF 89a specification) an Application Extension Block must not appear directly after a Graphic Control Extension block. Instead a Graphic-Rendering Block (see GIF Grammar) has to appear before.

So this GIF file (and f617c7af7f36296a37ddb419b828099c.gif - see below) is invalid.

Note: (slightly) confusingly the GIF 89a specification (section "23. Graphic Control Extension") tells:

```
"d. Extensions and Scope. The scope of this Extension is the graphic rendering block that follows it; it is possible for other extensions to be present between this block and its target. This block can modify the Image Descriptor Block and the Plain Text Extension."
```

which - at a first glance - seems to allow the Application Extension block between Graphic Control Extension and Image Descriptor.

This is clarified in section "20. Image Descriptor.":

```
"This block is a Graphic-Rendering Block, optionally preceded by one
or more Control blocks such as the Graphic Control Extension [...]"
```

By reading section "12. Blocks, Extensions and Scope." you can see that the Application Extension is clearly not a Control block.

## ce774930ac70449f38a18789c70095b8.gif

|| Format || GIF 89a ||

### Description

At offset 0x328 we have an Image Descriptor

```
0x328: 2C
       00 00 (Image Left Position)
       00 00 (Image Top Position)
       01 00 (Image Width)
       01 00 (Image Height)
0x331: 85 (Local Color Table with 2^(5+1) = 64 entries, i. e. 3*64=192 bytes)
```

So the Table Based Image Data begins at offset 0x3F2.

```
0x3F2: 00 (LZW Minimum Code Size)
```

The LZW Minimum Code Size field carries the value 0x0 - but it has to be 2 <= LZW Minimum Code Size <= 8.

## d5a0175c07418852152ef33a886a5029.gif

|| Format || GIF 89a ||

### Description

Signature (in Header block - directly at offset 0x0) 

```
0x00 0x49 0x46
```

instead of 
```
0x47 0x49 0x46
```

Even if we fix (or ignore) this error, we still get the same "invalid LZW Minimum Code Size" problem as in 2b5bc31d84703bfb9f371925f0e3e57d.gif and 5f09a896c191db3fa7ea6bdd5ebe9485.gif (at the same offset (0x338) and the same value there (0x48)).

## e34116d68f49c7852b362ec72a636df5.gif

|| Format || GIF 89a ||

### Description

The file begins with the usual GIF 89a header. Then the beginning of a
Logical Screen Descriptor follows:

```
0x06: 64 00 (Logical Screen Width)
      64 00 (Logical Screen Height)
```

After this the file ends prematurely.

## e6aa0c45a13dd7fc94f7b5451bd89bf4.gif

|| Format || GIF 89a ||

### Description

Apparently well formed.

## ea754e040929b7f9c157efc88c4d0eaf.gif

|| Format || GIF 89a ||

### Description

At offset 0x3BFD

```
0x3BFD: 48
```

The LZW decoder wants to read 11 bits of a code word - but can only read these 8 bits (0x48) - after this a 0x00 (Block Terminator) follows - this ends the Image Data (of Table Based Image Data). So the code word can't be read completely. Thus the file is invalid.

## ee6d1133f9264dc6467990e53d0bf104.gif

|| Format || GIF 87a ||

### Description

This is a GIF 87a file - but it contains a Graphic Control Extension Block (`Offset 0x30D: 21 F9 04 01 00 00 01 00`). According to GIF 89a specification the required version is GIF 89a - so this block has to be skipped.

At offset 0x420 a Data Sub-block of Image Data occures - with a length of 0x2B.

No look at offset (at this moment in the LZW decoding the Code Size is `0x0A = 10`)

```
0x449: 14 10
       00010100 00010000 (binary)
       0001       010000 (Code Word)
```

So we read the code 0x101 - the End of Information code.

After these two bytes another one follows in the block:

```
0x44B: 00
```

But the GIF 87a specification (the 89a one, too), clearly tells:

```
"An End of Information code is defined that explicitly indicates  the
end  of  the image data stream.  LZW processing terminates when this
code is encountered.  It must be the last code output by the encoder
for an image [!!!].  The value of this code is <Clear code>+1."
```

So the file is invalid.

Additionally no empty Data Sub-block (i. e. Length 0) follows.

If we changed the 0x2B at offset 0x420 to 0x2A the file would perhaps become correct.

## f617c7af7f36296a37ddb419b828099c.gif

|| Format || GIF 89a ||

### Description

```
0x00: 47 49 46 38 39 61 (Header)
0x06: 2C 01 2C 01 77 00 00 (Logical Screen Descriptor) - no Global Color Table
0x0D: 21 F9 (Graphic Control Extension)
      04 04 46 00 00 00
0x15: 21 FF (Application Extension)
      0B 4E 45 54 53 43 41 50 45 32 2E 30 03 01 00 00 00
0x28: 2C ... (Image Descriptor)
```

So we have the same situation as in bc7af0616c4ae99144c8600e7b39beea.gif (see the more detailed explanation there): a Graphic Control Extension block followed by an
Application Extension block - this is not allowed.

## f88b6907ee086c4c8ac4b8c395748c49.gif

|| Format || GIF 89a ||

### Description

At offset 0xB4A we read a code word of 7 bits:

```
0xB4A: 40 50
       01000000 01010000
       0          010000
```

So the code word is 0x20. This code word is invalid.

Why?

To understands look at the Image Descriptor (note that the data beginning at offset 0xB3E also looks like an Image Descriptor - but isn't) before at offset 0xB26:

```
0xB26: 2C
       00 00
       00 00
       01 00
       01 00
       82 (<Packed Fields>)
```

The flags <Packed Fields> tell that we have a local color table with 2^(2+1) = 8 entries. 

After the Local Color Table (offset 0xB48) we have the LZW Minimum Code Size field. It carries the value 0x06. So the Clear code is 2^6 = 64 and the End of Information code = <Clear code>+1 = 65.

So the 0x20 code above is not a compression code, but an index in the currently active color table (the Local Color Table). But the Local Color Table has only 8 entries. So the code word 0x20 above is invalid.

To find another error in this file, look at offset 0x7150, where you find an Image Descriptor

```
0x7150: 2C (Image Separator)
        0B 00 (Image Left Position)
        04 00 (Image Top Position)
        38 00 (Image Width)
        3D 00 (Image Height)
        00 (<Packed Fields> - no Local Color Table)
```

So this image is supposed to consist of Image Width * Image Height = 56 * 61 = 3416 pixels.

But the LZW-decoded Image Data of the Table Based Image Data block that follows contains 3417 indices into the active color table.

If we ignore this error, another one follows: at offset 0x9184, we have another Image Descriptor:

```
0x9184: 2C (Image Separator)
        03 00 (Image Left Position)
        03 00 (Image Top Position)
        46 00 (Image Width)
        41 00 (Image Height)
        00 (<Packed Fields> - no Local Color Table)
```

So this image should consist of Image Width * Image Height = 4550 pixels.

This time the LZW-decoded Image Data of the Table Based Image Data block that follows contains only 4537 indices into the active color table.

## fc3e2b992c559055267e26dc23e484c0.gif

|| Format || GIF 89a ||

### Description

If you look at offset 0x315, you see an Image Descriptor

```
0x315: 2C (Image Separator)
       00 00 (Image Left Position)
       00 00 (Image Top Position)
       64 00 (Image Width)
       2D 00 (Image Height)
	   07 (<Packed Fields> - no Local Color Table)
```

So the image consists of Image Width*Image Height = 2500 pixels.

But the Image Data in the Table Based Image Data that follows directly after (since we have no Local Color Table)

```
0x31F: 08 (LZW Minimum Code Size)
       ... (Image Data)
```

only contains 2499 indices into the active color table.
