<?xml version="1.0"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
<xsl:output method="xml" indent="yes"/>
<xsl:template match="string/ArrayOfBookCategory">
	<root>
		<xsl:for-each select="BookCategory">
			<Item>
				<Content>
					<Name><xsl:value-of select="CategoryName"/></Name>
				</Content>
			</Item>
			<xsl:for-each select="BookCategory/Book">
				<Item>
					<Content>
						<Name><xsl:value-of select="Title"/></Name>
					</Content>
				</Item>
			</xsl:for-each>
		</xsl:for-each>
	</root>
</xsl:template>
  </xsl:stylesheet>