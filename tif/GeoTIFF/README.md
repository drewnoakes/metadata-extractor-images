# GeoTIFF regression samples

These 47 small TIFF files (23,226 bytes in total) are recovered unchanged from
Vincent Privat's GeoTIFF contribution:

- https://github.com/drewnoakes/metadata-extractor-images/pull/53
- https://github.com/drewnoakes/metadata-extractor/pull/586
- https://github.com/drewnoakes/metadata-extractor/issues/278
- https://github.com/drewnoakes/metadata-extractor-dotnet/pull/324
- https://github.com/drewnoakes/metadata-extractor-dotnet/pull/374

This is the focused set used by the original Java GeoTIFF tests, not the larger
collection of demonstration images in the historical image PR. The libgeotiff
samples exercise geographic and projected coordinate systems, projection
parameters, units, datums, prime meridians, citations, GeoTIFF 1.1, and
PixelIsPoint. `GeogToWGS84GeoKey5.tif` exercises a seven-value transformation
parameter array and an offset tie point.

The `metadata/java` and `metadata/dotnet` files are produced by each library using
the corpus's existing text-output handlers. `metadata/diff` records remaining
cross-language differences. Runs use the en-US locale, and the Java run fixes the
time zone to UTC. Checkout-dependent file modification dates are omitted by the
existing handlers.

Baseline source revisions:

- Java: https://github.com/drewnoakes/metadata-extractor/commit/8d16e069476135596a5aaa66125eeb1922b93029
- Java feature PR: https://github.com/drewnoakes/metadata-extractor/pull/753
- .NET: https://github.com/drewnoakes/metadata-extractor-dotnet/commit/8a760313ff81418b1013a14b05fee35d8afccf94
- .NET parity PR: https://github.com/drewnoakes/metadata-extractor-dotnet/pull/477

The GeoTIFF directories and retained raw GeoTIFF tags agree across these samples.
Any remaining Sample Format (0x0153) description differences are pre-existing
TIFF-descriptor differences, not GeoTIFF decoding failures. Malformed metadata,
SHORT parameter arrays, scalar DOUBLE pools, per-IFD isolation, transformation
matrices, byte order, and BigTIFF layouts are covered by synthetic unit tests in
the library repositories rather than by adding more image fixtures.

## Files

```text
GeogAngularUnitsGeoKey_9114.tif
GeogGeodeticDatumGeoKey.tif
GeogPrimeMeridianGeoKey.tif
GeogToWGS84GeoKey5.tif
ProjLinearUnitsGeoKey_9036.tif
ProjectedCSTypeGeoKey_2046_transverse_mercator_south_oriented.tif
ProjectedCSTypeGeoKey_27200_new_zealand_mapping_grid.tif
ProjectedCSTypeGeoKey_28191_cassini_soldner.tif
ProjectedCSTypeGeoKey_29101_polyconic.tif
ProjectedCSTypeGeoKey_3032_polar_stereographic_variant_b.tif
ProjectedCSTypeGeoKey_3035_lambert_azimuthal_equal_area.tif
ProjectedCSTypeGeoKey_3083_albers_equal_area.tif
ProjectedCSTypeGeoKey_3410_lambert_cylindrical_equal_area.tif
ProjectedCSTypeGeoKey_3812_lcc2sp.tif
ProjectedCSTypeGeoKey_3814_transverse_mercator.tif
ProjectedCSTypeGeoKey_4087_equidistant_cylindrical.tif
ProjectedCSTypeGeoKey_5329_mercator1sp.tif
ProjectedCSTypeGeoKey_5456_lcc1sp.tif
ProjectedCSTypeGeoKey_5482_polar_stereographic_variant_a.tif
ProjectedCSTypeGeoKey_5588_oblique_stereographic.tif
ProjectedCSTypeGeoKey_5641_mercator2sp.tif
ProjectedCSTypeGeoKey_6808_hotine_oblique_mercator_variant_a.tif
ProjectedCSTypeGeoKey_8065_hotine_oblique_mercator_variant_b.tif
ProjectedCSTypeGeoKey_8441_oblique_mercator_laborde.tif
albers_equal_area.tif
byte.tif
byte_v11.tif
cassini_soldner.tif
equidistant_cylindrical.tif
hotine_oblique_mercator_variant_a.tif
hotine_oblique_mercator_variant_b.tif
lambert_azimuthal_equal_area.tif
lambert_cylindrical_equal_area.tif
lcc1sp.tif
lcc2sp.tif
mercator1sp.tif
mercator2sp.tif
new_zealand_mapping_grid.tif
oblique_mercator_laborde.tif
oblique_stereographic.tif
pcs_32064.tif
pixel_is_point_wgs84.tif
polar_stereographic_variant_a.tif
polar_stereographic_variant_b.tif
polyconic.tif
transverse_mercator.tif
transverse_mercator_south_oriented.tif
```
