<?xml version="1.0" encoding="UTF-8"?>
<xsl:stylesheet
        xmlns:xsl="http://www.w3.org/1999/XSL/Transform"
        xmlns:BM="http://www.univ-grenoble-alpes.fr/l3miage/BibliothequeMusical"
        version="1.0">

    <xsl:output method="html" encoding="UTF-8" indent="yes"/>

    <!-- Template principal -->
    <xsl:template match="/">
        <html>
            <head>
                <title>Bibliothèque Musicale</title>
                <link rel="stylesheet" href="../css/BibliothequeMusical.css"/>
            </head>
            <body>
                <h1>Ma Bibliothèque Musicale</h1>
                <xsl:apply-templates select="BM:BibliothequeMusical/BM:album"/>
            </body>
        </html>
    </xsl:template>

    <!-- Template album -->
    <xsl:template match="BM:album">
        <div class="album">
            <div class="album-header">
                <h2 class="album-titre">
                    <xsl:value-of select="BM:titre"/>
                </h2>
                <p class="album-artiste">
                    Par <xsl:value-of select="BM:artiste"/>
                </p>
                <span class="genre genre-{BM:genre}">
                    <xsl:value-of select="BM:genre"/>
                </span>
            </div>

            <div class="chansons">
                <h3>
                    Chansons (<xsl:value-of select="count(BM:chansons/BM:chanson)"/> titres)
                </h3>

                <table>
                    <tr>
                        <th class="numero">#</th>
                        <th>Titre</th>
                        <th class="dateSortie">Date de sortie</th>
                    </tr>

                    <xsl:apply-templates select="BM:chansons/BM:chanson"/>
                </table>
            </div>
        </div>
    </xsl:template>

    <!-- Template chanson -->
    <xsl:template match="BM:chanson">
        <tr>
            <td class="numero">
                <xsl:value-of select="position()"/>
            </td>
            <td>
                <xsl:value-of select="BM:titre"/>
            </td>
            <td class="duree">
                <xsl:value-of select="BM:dateSortie"/>
            </td>
        </tr>
    </xsl:template>

</xsl:stylesheet>
