<?xml version="1.0" encoding="ISO-8859-1"?>
<xsl:stylesheet version="1.0" xmlns:xsl="http://www.w3.org/1999/XSL/Transform">
	<xsl:output method="xml" version="1.0" encoding="utf-8" indent="yes"/>	
	<xsl:template match="/">
		<cards>
			<xsl:for-each select="//ROW">
				<card effects="true">
					<xsl:attribute name="id">
						<xsl:value-of select="card_number"/>
					</xsl:attribute>
					<cells>
						<cell position="A">
							<asset><xsl:value-of select="image_filename/DATA[1]"/></asset>
							<caption><xsl:value-of select="image_text_XML/DATA[1]"/></caption>
						</cell>
						<cell position="B">
							<asset><xsl:value-of select="image_filename/DATA[2]"/></asset>
							<caption><xsl:value-of select="image_text_XML/DATA[2]"/></caption>
						</cell>
						<cell position="C">
							<asset><xsl:value-of select="image_filename/DATA[3]"/></asset>
							<caption><xsl:value-of select="image_text_XML/DATA[3]"/></caption>
						</cell>
						<cell position="D">
							<asset><xsl:value-of select="image_filename/DATA[4]"/></asset>
							<caption><xsl:value-of select="image_text_XML/DATA[4]"/></caption>
						</cell>
					</cells>

					<questions>
						<question type="pick_1">
							<text><xsl:value-of select="Pick1Question_XML"/></text>
							<answers><xsl:value-of select="Pick1Answer"/></answers>
						</question>
						<question type="pick_2">
							<text><xsl:value-of select="Pick2Question_XML"/></text>
							<answers><xsl:value-of select="Pick2Answer"/></answers>
						</question>
						<question type="pick_3">
							<text><xsl:value-of select="Pick3Question_XML"/></text>
							<answers><xsl:value-of select="Pick3Answer"/></answers>
						</question>
						<question type="solo_pick_1">
							<text><xsl:value-of select="SoloPickQuestion_XML"/></text>
							<answers><xsl:value-of select="SoloPickAnswer"/></answers>
						</question>
						<question type="vote">
							<text><xsl:value-of select="VOTING_QUESTION"/></text>
						</question>
						<question type="vote_alternate">
					      <text><xsl:value-of select="VOTING_QUESTION_XML"/></text>
					      <opinions>
					        <opinion position="A"><xsl:value-of select="publicPercentage_A"/></opinion>
					        <opinion position="B"><xsl:value-of select="publicPercentage_B"/></opinion>
					        <opinion position="C"><xsl:value-of select="publicPercentage_C"/></opinion>
					        <opinion position="D"><xsl:value-of select="publicPercentage_D"/></opinion>
					      </opinions>
					    </question>
					</questions>
				</card>
			</xsl:for-each>
		</cards>
	</xsl:template>
</xsl:stylesheet>