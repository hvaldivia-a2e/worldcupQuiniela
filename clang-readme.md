# clang configuration settings for Thames source
## Background
---
Add some nice text explaining why this is important and what we need to do moving forward...
## Summary of Current Settings
---
|Setting|Current Value|
|-------|-------------|
|[AccessModifierOffset](#AccessModifierOffset)|-1|
|[AlignAfterOpenBracket](###AlignAfterOpenBracket)|AlwaysBreak|
|[AlignConsecutiveAssignments](###AlignConsecutiveAssignments)|false|
|[AlignConsecutiveDeclarations](###AlignConsecutiveDeclarations)|false|
|[AlignEscapedNewlinesLeft](###AlignEscapedNewlinesLeft)|true|
|[AlignOperands](###AlignOperands)|false|
|[AlignTrailingComments](###AlignTrailingComments)|false|
|[AllowAllParametersOfDeclarationOnNextLine](###AllowAllParametersOfDeclarationOnNextLine)|false|
|[AllowShortBlocksOnASingleLine](###AllowShortBlocksOnASingleLine)|false|
|[AllowShortCaseLabelsOnASingleLine](###AllowShortCaseLabelsOnASingleLine)|false|
|[AllowShortFunctionsOnASingleLine](###AllowShortFunctionsOnASingleLine)|Empty|
|[AllowShortIfStatementsOnASingleLine](###AllowShortIfStatementsOnASingleLine)|false|
|[AllowShortLoopsOnASingleLine](###AllowShortLoopsOnASingleLine)|false|
|[AlwaysBreakAfterReturnType](###AlwaysBreakAfterReturnType)|None|
|[AlwaysBreakBeforeMultilineStrings](###AlwaysBreakBeforeMultilineStrings)|true|
|[AlwaysBreakTemplateDeclarations](###AlwaysBreakTemplateDeclarations)|true|
|[BinPackArguments](###BinPackArguments)|false|
|[BinPackParameters](###BinPackParameters)|false|
|[BraceWrapping](###BraceWrapping)|<table><tbody><tr><td>AfterClass</td><td>false</td></tr><tr><td>AfterControlStatement</td><td>false</td></tr><tr><td>AfterEnum</td><td>false</td></tr><tr><td>AfterFunction</td><td>false</td></tr><tr><td>AfterNamespace</td><td>false</td></tr><tr><td>AfterObjDeclaration</td><td>false</td></tr><tr><td>AfterControlStruct</td><td>false</td></tr><tr><td>AfterUnion</td><td>false</td></tr><tr><td>BeforeCatch</td><td>false</td></tr><tr><td>BeforeElse</td><td>false</td></tr><tr><td>IndentBraces</td><td>false</td></tr></tbody></table> |
|[BreakBeforeBinaryOperators](###BreakBeforeBinaryOperators)|None|
|[BreakBeforeBraces](###BreakBeforeBraces)|Attach|
|[BreakBeforeTernaryOperators](###BreakBeforeTernaryOperators)|true|
|[BreakConstructorInitializersBeforeComma](###BreakConstructorInitializersBeforeComma)|false|
|[BreakAfterJavaFieldAnnotations](###BreakAfterJavaFieldAnnotations)|false|
|[BreakStringLiterals](###BreakStringLiterals)|false|
|[ColumnLimit](###ColumnLimit)|100|
|[CommentPragmas](###CommentPragmas)|'^ IWYU pragma|
|[ConstructorInitializerAllOnOneLineOrOnePerLine](###ConstructorInitializerAllOnOneLineOrOnePerLine)|true|
|[ConstructorInitializerIndentWidth](###ConstructorInitializerIndentWidth)|4|
|[ContinuationIndentWidth](###ContinuationIndentWidth)|4|
|[Cpp11BracedListStyle](###Cpp11BracedListStyle)|true|
|[DerivePointerAlignment](###DerivePointerAlignment)|false|
|[DisableFormat](###DisableFormat)|false|
|[ForEachMacros](###ForEachMacros)|[ FOR_EACH_RANGE, FOR_EACH, ]|
|[IncludeCategories](###IncludeCategories)|<table><tbody><tr><td>Regex<br>Priority</td><td>'^<.*\.h(pp)?>'<br>1</td></tr> <tr><td>Regex<br>Priority</td><td>'^<.*'<br>2</td></tr>  <tr><td>Regex<br>Priority</td><td>'.*'<br>3</td></tr>  </tbody></table> |
|[IndentCaseLabels](###IndentCaseLabels)|true|
|[IndentWidth](###IndentWidth)|2|
|[IndentWrappedFunctionNames](###IndentWrappedFunctionNames)|false|
|[KeepEmptyLinesAtTheStartOfBlocks](###KeepEmptyLinesAtTheStartOfBlocks)|false|
|[MacroBlockBegin](###MacroBlockBegin)|''|
|[MacroBlockEnd](###MacroBlockEnd)|''|
|[MaxEmptyLinesToKeep](###MaxEmptyLinesToKeep)|1|
|[NamespaceIndentation](###NamespaceIndentation)|None|
|[ObjCBlockIndentWidth](###ObjCBlockIndentWidth)|2|
|[ObjCSpaceAfterProperty](###ObjCSpaceAfterProperty)|false|
|[ObjCSpaceBeforeProtocolList](###ObjCSpaceBeforeProtocolList)|false|
|[PenaltyBreakBeforeFirstCallParameter](###PenaltyBreakBeforeFirstCallParameter)|1|
|[PenaltyBreakComment](###PenaltyBreakComment)|300|
|[PenaltyBreakFirstLessLess](###PenaltyBreakFirstLessLess)|120|
|[PenaltyBreakString](###PenaltyBreakString)|1000|
|[PenaltyExcessCharacter](###PenaltyExcessCharacter)|1000000|
|[PenaltyReturnTypeOnItsOwnLine](###PenaltyReturnTypeOnItsOwnLine)|200|
|[PointerAlignment](###PointerAlignment)|Left|
|[ReflowComments](###ReflowComments)|true|
|[SortIncludes](###SortIncludes)|true|
|[SpaceAfterCStyleCast](###SpaceAfterCStyleCast)|false|
|[SpaceBeforeAssignmentOperators](###SpaceBeforeAssignmentOperators)|true|
|[SpaceBeforeParens](###SpaceBeforeParens)|ControlStatements|
|[SpaceInEmptyParentheses](###SpaceInEmptyParentheses)|false|
|[SpacesBeforeTrailingComments](###SpacesBeforeTrailingComments)|1|
|[SpacesInAngles](###SpacesInAngles)|false|
|[SpacesInContainerLiterals](###SpacesInContainerLiterals)|true|
|[SpacesInCStyleCastParentheses](###SpacesInCStyleCastParentheses)|false|
|[SpacesInParentheses](###SpacesInParentheses)|false|
|[SpacesInSquareBrackets](###SpacesInSquareBrackets)|false|
|[Standard](###Standard)|Cpp11|
|[TabWidth](###TabWidth)|4|
|[UseTab](###UseTab)|Never|
## Settings detailed description
---
### AccessModifierOffset
<dd>The extra indent or outdent of access modifiers, e.g. <strong>public:</strong>.</dd>

### AlignAfterOpenBracket
<dd><p class="first">If <strong>true</strong>, horizontally aligns arguments after an open bracket.</p>
<p>This applies to round brackets (parentheses), angle brackets and square
brackets.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>BAS_Align</strong> (in configuration: <strong>Align</strong>)
Align parameters on the open bracket, e.g.:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">someLongFunction</span><span class="p">(</span><span class="n">argument1</span><span class="p">,</span>
                 <span class="n">argument2</span><span class="p">);</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BAS_DontAlign</strong> (in configuration: <strong>DontAlign</strong>)
Don’t align, instead use <strong>ContinuationIndentWidth</strong>, e.g.:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">someLongFunction</span><span class="p">(</span><span class="n">argument1</span><span class="p">,</span>
    <span class="n">argument2</span><span class="p">);</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BAS_AlwaysBreak</strong> (in configuration: <strong>AlwaysBreak</strong>)
Always break after an open bracket, if the parameters don’t fit
on a single line, e.g.:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">someLongFunction</span><span class="p">(</span>
    <span class="n">argument1</span><span class="p">,</span> <span class="n">argument2</span><span class="p">);</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BAS_BlockIndent</strong> (in configuration: <strong>BlockIndent</strong>)
Always break after an open bracket, if the parameters don’t fit
on a single line. Closing brackets will be placed on a new line.
E.g.:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">someLongFunction</span><span class="p">(</span>
    <span class="n">argument1</span><span class="p">,</span> <span class="n">argument2</span>
<span class="p">)</span>
</pre></div>
</div>
<div class="admonition warning">
<p class="first admonition-title">Warning</p>
<p class="last">Note: This currently only applies to parentheses.</p>
</div>
</li>
</ul>
</dd>

### AlignConsecutiveAssignments
<dd><p class="first">Style of aligning consecutive assignments.</p>
<p><strong>Consecutive</strong> will result in formattings like:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
</pre></div>
</div>
<p>Nested configuration flags:</p>
<p>Alignment options.</p>
<p>They can also be read as a whole for compatibility. The choices are:
- None
- Consecutive
- AcrossEmptyLines
- AcrossComments
- AcrossEmptyLinesAndComments</p>
<p>For example, to align across empty lines and not across comments, either
of these work.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">AlignConsecutiveMacros</span><span class="p">:</span> <span class="n">AcrossEmptyLines</span>

<span class="nl">AlignConsecutiveMacros</span><span class="p">:</span>
  <span class="nl">Enabled</span><span class="p">:</span> <span class="nb">true</span>
  <span class="nl">AcrossEmptyLines</span><span class="p">:</span> <span class="nb">true</span>
  <span class="nl">AcrossComments</span><span class="p">:</span> <span class="nb">false</span>
</pre></div>
</div>
<ul class="last">
<li><p class="first"><strong>bool</span> <span class="pre">Enabled</strong> Whether aligning is enabled.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp">#define SHORT_NAME       42</span>
<span class="cp">#define LONGER_NAME      0x007f</span>
<span class="cp">#define EVEN_LONGER_NAME (2)</span>
<span class="cp">#define foo(x)           (x * x)</span>
<span class="cp">#define bar(y, z)        (y + z)</span>

<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="nl">aaaa</span> <span class="p">:</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="nl">b</span>    <span class="p">:</span> <span class="mi">12</span><span class="p">;</span>
<span class="kt">int</span> <span class="nl">ccc</span>  <span class="p">:</span> <span class="mi">8</span><span class="p">;</span>

<span class="kt">int</span>         <span class="n">aaaa</span> <span class="o">=</span> <span class="mi">12</span><span class="p">;</span>
<span class="kt">float</span>       <span class="n">b</span> <span class="o">=</span> <span class="mi">23</span><span class="p">;</span>
<span class="n">std</span><span class="o">::</span><span class="n">string</span> <span class="n">ccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AcrossEmptyLines</strong> Whether to align across empty lines.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="n">d</span>            <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="n">d</span> <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AcrossComments</strong> Whether to align across comments.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">d</span>    <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
<span class="cm">/* A comment. */</span>
<span class="kt">double</span> <span class="n">e</span> <span class="o">=</span> <span class="mi">4</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">d</span> <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
<span class="cm">/* A comment. */</span>
<span class="kt">double</span> <span class="n">e</span> <span class="o">=</span> <span class="mi">4</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AlignCompound</strong> Only for <strong>AlignConsecutiveAssignments</strong>.  Whether compound assignments
like <strong>+=</strong> are aligned along with <strong>=</strong>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">a</span>   <span class="o">&amp;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span>  <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">a</span> <span class="o">&amp;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">PadOperators</strong> Only for <strong>AlignConsecutiveAssignments</strong>.  Whether short assignment
operators are left-padded to the same length as long ones in order to
put all assignment operators to the right of the left hand side.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">a</span>   <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span>   <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="n">a</span>     <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">a</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="n">a</span>     <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AlignConsecutiveDeclarations
<dd><p class="first">Style of aligning consecutive declarations.</p>
<p><strong>Consecutive</strong> will align the declaration names of consecutive lines.
This will result in formattings like:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span>         <span class="n">aaaa</span> <span class="o">=</span> <span class="mi">12</span><span class="p">;</span>
<span class="kt">float</span>       <span class="n">b</span> <span class="o">=</span> <span class="mi">23</span><span class="p">;</span>
<span class="n">std</span><span class="o">::</span><span class="n">string</span> <span class="n">ccc</span><span class="p">;</span>
</pre></div>
</div>
<p>Nested configuration flags:</p>
<p>Alignment options.</p>
<p>They can also be read as a whole for compatibility. The choices are:
- None
- Consecutive
- AcrossEmptyLines
- AcrossComments
- AcrossEmptyLinesAndComments</p>
<p>For example, to align across empty lines and not across comments, either
of these work.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">AlignConsecutiveMacros</span><span class="p">:</span> <span class="n">AcrossEmptyLines</span>

<span class="nl">AlignConsecutiveMacros</span><span class="p">:</span>
  <span class="nl">Enabled</span><span class="p">:</span> <span class="nb">true</span>
  <span class="nl">AcrossEmptyLines</span><span class="p">:</span> <span class="nb">true</span>
  <span class="nl">AcrossComments</span><span class="p">:</span> <span class="nb">false</span>
</pre></div>
</div>
<ul class="last">
<li><p class="first"><strong>bool</span> <span class="pre">Enabled</strong> Whether aligning is enabled.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp">#define SHORT_NAME       42</span>
<span class="cp">#define LONGER_NAME      0x007f</span>
<span class="cp">#define EVEN_LONGER_NAME (2)</span>
<span class="cp">#define foo(x)           (x * x)</span>
<span class="cp">#define bar(y, z)        (y + z)</span>

<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="nl">aaaa</span> <span class="p">:</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="nl">b</span>    <span class="p">:</span> <span class="mi">12</span><span class="p">;</span>
<span class="kt">int</span> <span class="nl">ccc</span>  <span class="p">:</span> <span class="mi">8</span><span class="p">;</span>

<span class="kt">int</span>         <span class="n">aaaa</span> <span class="o">=</span> <span class="mi">12</span><span class="p">;</span>
<span class="kt">float</span>       <span class="n">b</span> <span class="o">=</span> <span class="mi">23</span><span class="p">;</span>
<span class="n">std</span><span class="o">::</span><span class="n">string</span> <span class="n">ccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AcrossEmptyLines</strong> Whether to align across empty lines.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="n">d</span>            <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span>            <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="kt">int</span> <span class="n">somelongname</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="kt">double</span> <span class="n">c</span>         <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>

<span class="kt">int</span> <span class="n">d</span> <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AcrossComments</strong> Whether to align across comments.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">d</span>    <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
<span class="cm">/* A comment. */</span>
<span class="kt">double</span> <span class="n">e</span> <span class="o">=</span> <span class="mi">4</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">d</span> <span class="o">=</span> <span class="mi">3</span><span class="p">;</span>
<span class="cm">/* A comment. */</span>
<span class="kt">double</span> <span class="n">e</span> <span class="o">=</span> <span class="mi">4</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">AlignCompound</strong> Only for <strong>AlignConsecutiveAssignments</strong>.  Whether compound assignments
like <strong>+=</strong> are aligned along with <strong>=</strong>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">a</span>   <span class="o">&amp;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span>  <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">a</span> <span class="o">&amp;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>bool</span> <span class="pre">PadOperators</strong> Only for <strong>AlignConsecutiveAssignments</strong>.  Whether short assignment
operators are left-padded to the same length as long ones in order to
put all assignment operators to the right of the left hand side.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">a</span>   <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span>   <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="n">a</span>     <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">a</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>

<span class="n">a</span>     <span class="o">=</span> <span class="mi">2</span><span class="p">;</span>
<span class="n">bbb</span> <span class="o">&gt;&gt;=</span> <span class="mi">2</span><span class="p">;</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AlignOperands
<dd><p class="first">If <strong>true</strong>, horizontally align operands of binary and ternary
expressions.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>OAS_DontAlign</strong> (in configuration: <strong>DontAlign</strong>)
Do not align operands of binary and ternary expressions.
The wrapped lines are indented <strong>ContinuationIndentWidth</strong> spaces from
the start of the line.</p>
</li>
<li><p class="first"><strong>OAS_Align</strong> (in configuration: <strong>Align</strong>)
Horizontally align operands of binary and ternary expressions.</p>
<p>Specifically, this aligns operands of a single expression that needs
to be split over multiple lines, e.g.:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="n">aaa</span> <span class="o">=</span> <span class="n">bbbbbbbbbbbbbbb</span> <span class="o">+</span>
          <span class="n">ccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
<p>When <strong>BreakBeforeBinaryOperators</strong> is set, the wrapped operator is
aligned with the operand on the first line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="n">aaa</span> <span class="o">=</span> <span class="n">bbbbbbbbbbbbbbb</span>
          <span class="o">+</span> <span class="n">ccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>OAS_AlignAfterOperator</strong> (in configuration: <strong>AlignAfterOperator</strong>)
Horizontally align operands of binary and ternary expressions.</p>
<p>This is similar to <strong>AO_Align</strong>, except when
<strong>BreakBeforeBinaryOperators</strong> is set, the operator is un-indented so
that the wrapped operand is aligned with the operand on the first line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="n">aaa</span> <span class="o">=</span> <span class="n">bbbbbbbbbbbbbbb</span>
        <span class="o">+</span> <span class="n">ccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AlignTrailingComments
<dd><p class="first">If <strong>true</strong>, aligns trailing comments.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                   <span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span><span class="p">;</span>     <span class="c1">// My comment a      vs.     int a; // My comment a</span>
<span class="kt">int</span> <span class="n">b</span> <span class="o">=</span> <span class="mi">2</span><span class="p">;</span> <span class="c1">// comment  b                int b = 2; // comment about b</span>
</pre></div>
</div>
</dd>

### AllowAllParametersOfDeclarationOnNextLine
<dd><p class="first">If the function declaration doesn’t fit on a line,
allow putting all parameters of a function declaration onto
the next line even if <strong>BinPackParameters</strong> is <strong>false</strong>.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">myFunction</span><span class="p">(</span>
    <span class="kt">int</span> <span class="n">a</span><span class="p">,</span> <span class="kt">int</span> <span class="n">b</span><span class="p">,</span> <span class="kt">int</span> <span class="n">c</span><span class="p">,</span> <span class="kt">int</span> <span class="n">d</span><span class="p">,</span> <span class="kt">int</span> <span class="n">e</span><span class="p">);</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">myFunction</span><span class="p">(</span><span class="kt">int</span> <span class="n">a</span><span class="p">,</span>
                <span class="kt">int</span> <span class="n">b</span><span class="p">,</span>
                <span class="kt">int</span> <span class="n">c</span><span class="p">,</span>
                <span class="kt">int</span> <span class="n">d</span><span class="p">,</span>
                <span class="kt">int</span> <span class="n">e</span><span class="p">);</span>
</pre></div>
</div>
</dd>

### AllowShortBlocksOnASingleLine
<dd><p class="first">Dependent on the value, <strong>while</span> <span class="pre">(true)</span> <span class="pre">{</span> <span class="pre">continue;</span> <span class="pre">}</strong> can be put on a
single line.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SBS_Never</strong> (in configuration: <strong>Never</strong>)
Never merge blocks into a single line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
  <span class="k">continue</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBS_Empty</strong> (in configuration: <strong>Empty</strong>)
Only merge empty blocks.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{}</span>
<span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
  <span class="k">continue</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBS_Always</strong> (in configuration: <strong>Always</strong>)
Always merge short blocks into a single line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{}</span>
<span class="k">while</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span> <span class="k">continue</span><span class="p">;</span> <span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AllowShortCaseLabelsOnASingleLine
<dd><p class="first">If <strong>true</strong>, short case labels will be contracted to a single line.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                   <span class="nb">false</span><span class="o">:</span>
<span class="k">switch</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span> <span class="p">{</span>                    <span class="n">vs</span><span class="p">.</span>     <span class="k">switch</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span> <span class="p">{</span>
<span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="n">x</span> <span class="o">=</span> <span class="mi">1</span><span class="p">;</span> <span class="k">break</span><span class="p">;</span>                   <span class="k">case</span> <span class="mi">1</span><span class="o">:</span>
<span class="k">case</span> <span class="mi">2</span><span class="o">:</span> <span class="k">return</span><span class="p">;</span>                           <span class="n">x</span> <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
<span class="p">}</span>                                         <span class="k">break</span><span class="p">;</span>
                                        <span class="k">case</span> <span class="mi">2</span><span class="o">:</span>
                                          <span class="k">return</span><span class="p">;</span>
                                        <span class="p">}</span>
</pre></div>
</div>
</dd>

### AllowShortFunctionsOnASingleLine
<dd><p class="first">Dependent on the value, <strong>int</span> <span class="pre">f()</span> <span class="pre">{</span> <span class="pre">return</span> <span class="pre">0;</span> <span class="pre">}</strong> can be put on a
single line.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SFS_None</strong> (in configuration: <strong>None</strong>)
Never merge functions into a single line.</p>
</li>
<li><p class="first"><strong>SFS_InlineOnly</strong> (in configuration: <strong>InlineOnly</strong>)
Only merge functions defined inside a class. Same as “inline”,
except it does not implies “empty”: i.e. top level empty functions
are not merged either.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">Foo</span> <span class="p">{</span>
  <span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">();</span> <span class="p">}</span>
<span class="p">};</span>
<span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span>
<span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SFS_Empty</strong> (in configuration: <strong>Empty</strong>)
Only merge empty functions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{}</span>
<span class="kt">void</span> <span class="nf">f2</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">bar2</span><span class="p">();</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SFS_Inline</strong> (in configuration: <strong>Inline</strong>)
Only merge functions defined inside a class. Implies “empty”.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">Foo</span> <span class="p">{</span>
  <span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">();</span> <span class="p">}</span>
<span class="p">};</span>
<span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span>
<span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SFS_All</strong> (in configuration: <strong>All</strong>)
Merge all functions fitting on a single line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">Foo</span> <span class="p">{</span>
  <span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">();</span> <span class="p">}</span>
<span class="p">};</span>
<span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="n">bar</span><span class="p">();</span> <span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AllowShortIfStatementsOnASingleLine
<dd><p class="first">Dependent on the value, <strong>if</span> <span class="pre">(a)</span> <span class="pre">return;</strong> can be put on a single line.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SIS_Never</strong> (in configuration: <strong>Never</strong>)
Never put short ifs on the same line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">if</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>
<span class="k">else</span>
  <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">c</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="p">{</span>
  <span class="k">return</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SIS_WithoutElse</strong> (in configuration: <strong>WithoutElse</strong>)
Put short ifs on the same line only if there is no else statement.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">if</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>
<span class="k">else</span>
  <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">c</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="p">{</span>
  <span class="k">return</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SIS_OnlyFirstIf</strong> (in configuration: <strong>OnlyFirstIf</strong>)
Put short ifs, but not else ifs nor else statements, on the same line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">if</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="nf">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
  <span class="k">return</span><span class="p">;</span>
<span class="k">else</span>
  <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">c</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="p">{</span>
  <span class="k">return</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SIS_AllIfsAndElse</strong> (in configuration: <strong>AllIfsAndElse</strong>)
Always put short ifs, else ifs and else statements on the same
line.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">if</span> <span class="p">(</span><span class="n">a</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="k">return</span><span class="p">;</span>

<span class="k">if</span> <span class="p">(</span><span class="n">c</span><span class="p">)</span> <span class="k">return</span><span class="p">;</span>
<span class="k">else</span> <span class="p">{</span>
  <span class="k">return</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AllowShortLoopsOnASingleLine
<dd>If <strong>true</strong>, <strong>while</span> <span class="pre">(true)</span> <span class="pre">continue;</strong> can be put on a single
line.</dd>

### AlwaysBreakAfterReturnType
<dd><p class="first">The function declaration return type breaking style to use.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>RTBS_None</strong> (in configuration: <strong>None</strong>)
Break after return type automatically.
<strong>PenaltyReturnTypeOnItsOwnLine</strong> is taken into account.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">A</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="k">return</span> <span class="mi">0</span><span class="p">;</span> <span class="p">};</span>
<span class="p">};</span>
<span class="kt">int</span> <span class="nf">f</span><span class="p">();</span>
<span class="kt">int</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="k">return</span> <span class="mi">1</span><span class="p">;</span> <span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>RTBS_All</strong> (in configuration: <strong>All</strong>)
Always break after the return type.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">A</span> <span class="p">{</span>
  <span class="kt">int</span>
  <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
    <span class="k">return</span> <span class="mi">0</span><span class="p">;</span>
  <span class="p">};</span>
<span class="p">};</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">();</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">return</span> <span class="mi">1</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>RTBS_TopLevel</strong> (in configuration: <strong>TopLevel</strong>)
Always break after the return types of top-level functions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">A</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="k">return</span> <span class="mi">0</span><span class="p">;</span> <span class="p">};</span>
<span class="p">};</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">();</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">return</span> <span class="mi">1</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>RTBS_AllDefinitions</strong> (in configuration: <strong>AllDefinitions</strong>)
Always break after the return type of function definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">A</span> <span class="p">{</span>
  <span class="kt">int</span>
  <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
    <span class="k">return</span> <span class="mi">0</span><span class="p">;</span>
  <span class="p">};</span>
<span class="p">};</span>
<span class="kt">int</span> <span class="nf">f</span><span class="p">();</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">return</span> <span class="mi">1</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>RTBS_TopLevelDefinitions</strong> (in configuration: <strong>TopLevelDefinitions</strong>)
Always break after the return type of top-level definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">A</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span> <span class="k">return</span> <span class="mi">0</span><span class="p">;</span> <span class="p">};</span>
<span class="p">};</span>
<span class="kt">int</span> <span class="nf">f</span><span class="p">();</span>
<span class="kt">int</span>
<span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">return</span> <span class="mi">1</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### AlwaysBreakBeforeMultilineStrings
<dd><p class="first">If <strong>true</strong>, always break before multiline string literals.</p>
<p>This flag is mean to make cases where there are multiple multiline strings
in a file look more consistent. Thus, it will only take effect if wrapping
the string at that point leads to it being indented
<strong>ContinuationIndentWidth</strong> spaces from the start of the line.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="n">aaaa</span> <span class="o">=</span>                         <span class="n">vs</span><span class="p">.</span>     <span class="n">aaaa</span> <span class="o">=</span> <span class="s">&quot;bbbb&quot;</span>
    <span class="s">&quot;bbbb&quot;</span>                                    <span class="s">&quot;cccc&quot;</span><span class="p">;</span>
    <span class="s">&quot;cccc&quot;</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### AlwaysBreakTemplateDeclarations
<dd><p class="first">The template declaration breaking style to use.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>BTDS_No</strong> (in configuration: <strong>No</strong>)
Do not force break before declaration.
<strong>PenaltyBreakTemplateDeclaration</strong> is taken into account.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span> <span class="n">T</span> <span class="n">foo</span><span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span> <span class="n">T</span> <span class="n">foo</span><span class="p">(</span><span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
                            <span class="kt">int</span> <span class="n">bbbbbbbbbbbbbbbbbbbbb</span><span class="p">)</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BTDS_MultiLine</strong> (in configuration: <strong>MultiLine</strong>)
Force break after template declaration only when the following
declaration spans multiple lines.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span> <span class="n">T</span> <span class="n">foo</span><span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span>
<span class="n">T</span> <span class="n">foo</span><span class="p">(</span><span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
      <span class="kt">int</span> <span class="n">bbbbbbbbbbbbbbbbbbbbb</span><span class="p">)</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BTDS_Yes</strong> (in configuration: <strong>Yes</strong>)
Always break after template declaration.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span>
<span class="n">T</span> <span class="n">foo</span><span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">template</span> <span class="o">&lt;</span><span class="k">typename</span> <span class="nc">T</span><span class="o">&gt;</span>
<span class="n">T</span> <span class="n">foo</span><span class="p">(</span><span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
      <span class="kt">int</span> <span class="n">bbbbbbbbbbbbbbbbbbbbb</span><span class="p">)</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### BinPackArguments
<dd><p class="first">If <strong>false</strong>, a function call’s arguments will either be all on the
same line or will have one line each.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">f</span><span class="p">(</span><span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span> <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
    <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span><span class="p">);</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">f</span><span class="p">(</span><span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
    <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
    <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span><span class="p">);</span>
<span class="p">}</span>
</pre></div>
</div>
</dd>

### BinPackParameters
<dd><p class="first">If <strong>false</strong>, a function declaration’s or function definition’s
parameters will either all be on the same line or will have one line each.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">(</span><span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span> <span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
       <span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span><span class="p">)</span> <span class="p">{}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">(</span><span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
       <span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaa</span><span class="p">,</span>
       <span class="kt">int</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span><span class="p">)</span> <span class="p">{}</span>
</pre></div>
</div>
</dd>

### BraceWrapping
<dd><p class="first">Control of individual brace wrapping cases.</p>
<p>If <code class="docutils literal notranslate"><span class="pre">BreakBeforeBraces</span></code> is set to <code class="docutils literal notranslate"><span class="pre">BS_Custom</span></code>, use this to specify how
each individual brace case should be handled. Otherwise, this is ignored.</p>
<div class="highlight-yaml notranslate"><div class="highlight"><pre><span></span><span class="c1"># Example of usage:</span>
<span class="l l-Scalar l-Scalar-Plain">BreakBeforeBraces</span><span class="p p-Indicator">:</span> <span class="l l-Scalar l-Scalar-Plain">Custom</span>
<span class="l l-Scalar l-Scalar-Plain">BraceWrapping</span><span class="p p-Indicator">:</span>
  <span class="l l-Scalar l-Scalar-Plain">AfterEnum</span><span class="p p-Indicator">:</span> <span class="l l-Scalar l-Scalar-Plain">true</span>
  <span class="l l-Scalar l-Scalar-Plain">AfterStruct</span><span class="p p-Indicator">:</span> <span class="l l-Scalar l-Scalar-Plain">false</span>
  <span class="l l-Scalar l-Scalar-Plain">SplitEmptyFunction</span><span class="p p-Indicator">:</span> <span class="l l-Scalar l-Scalar-Plain">false</span>
</pre></div>
</div>
<p>Nested configuration flags:</p>
<ul class="last">
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterClass</span></code> Wrap class definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">class</span> <span class="nc">foo</span> <span class="p">{};</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">class</span> <span class="nc">foo</span>
<span class="p">{};</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterControlStatement</span></code> Wrap control statements (<code class="docutils literal notranslate"><span class="pre">if</span></code>/<code class="docutils literal notranslate"><span class="pre">for</span></code>/<code class="docutils literal notranslate"><span class="pre">while</span></code>/<code class="docutils literal notranslate"><span class="pre">switch</span></code>/..).</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">())</span>
<span class="p">{</span>
<span class="p">}</span> <span class="k">else</span>
<span class="p">{}</span>
<span class="k">for</span> <span class="p">(</span><span class="kt">int</span> <span class="n">i</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span> <span class="n">i</span> <span class="o">&lt;</span> <span class="mi">10</span><span class="p">;</span> <span class="o">++</span><span class="n">i</span><span class="p">)</span>
<span class="p">{}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">())</span> <span class="p">{</span>
<span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">for</span> <span class="p">(</span><span class="kt">int</span> <span class="n">i</span> <span class="o">=</span> <span class="mi">0</span><span class="p">;</span> <span class="n">i</span> <span class="o">&lt;</span> <span class="mi">10</span><span class="p">;</span> <span class="o">++</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterEnum</span></code> Wrap enum definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">enum</span> <span class="nl">X</span> <span class="p">:</span> <span class="kt">int</span>
<span class="p">{</span>
  <span class="n">B</span>
<span class="p">};</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">enum</span> <span class="nl">X</span> <span class="p">:</span> <span class="kt">int</span> <span class="p">{</span> <span class="n">B</span> <span class="p">};</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterFunction</span></code> Wrap function definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">foo</span><span class="p">()</span>
<span class="p">{</span>
  <span class="n">bar</span><span class="p">();</span>
  <span class="n">bar2</span><span class="p">();</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">foo</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">bar</span><span class="p">();</span>
  <span class="n">bar2</span><span class="p">();</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterNamespace</span></code> Wrap namespace definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">namespace</span>
<span class="p">{</span>
<span class="kt">int</span> <span class="n">foo</span><span class="p">();</span>
<span class="kt">int</span> <span class="nf">bar</span><span class="p">();</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">namespace</span> <span class="p">{</span>
<span class="kt">int</span> <span class="n">foo</span><span class="p">();</span>
<span class="kt">int</span> <span class="nf">bar</span><span class="p">();</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterObjCDeclaration</span></code> Wrap ObjC definitions (interfaces, implementations…).
&#64;autoreleasepool and &#64;synchronized blocks are wrapped
according to <cite>AfterControlStatement</cite> flag.</p>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterStruct</span></code> Wrap struct definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">struct</span> <span class="n">foo</span>
<span class="p">{</span>
  <span class="kt">int</span> <span class="n">x</span><span class="p">;</span>
<span class="p">};</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">struct</span> <span class="n">foo</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="n">x</span><span class="p">;</span>
<span class="p">};</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterUnion</span></code> Wrap union definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">union</span> <span class="n">foo</span>
<span class="p">{</span>
  <span class="kt">int</span> <span class="n">x</span><span class="p">;</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">union</span> <span class="n">foo</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="n">x</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">AfterExternBlock</span></code> Wrap extern blocks.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">extern</span> <span class="s">&quot;C&quot;</span>
<span class="p">{</span>
  <span class="kt">int</span> <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">extern</span> <span class="s">&quot;C&quot;</span> <span class="p">{</span>
<span class="kt">int</span> <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">BeforeCatch</span></code> Wrap before <code class="docutils literal notranslate"><span class="pre">catch</span></code>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">try</span> <span class="p">{</span>
  <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span>
<span class="k">catch</span> <span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">try</span> <span class="p">{</span>
  <span class="n">foo</span><span class="p">();</span>
<span class="p">}</span> <span class="k">catch</span> <span class="p">()</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">BeforeElse</span></code> Wrap before <code class="docutils literal notranslate"><span class="pre">else</span></code>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">())</span> <span class="p">{</span>
<span class="p">}</span>
<span class="k">else</span> <span class="p">{</span>
<span class="p">}</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">())</span> <span class="p">{</span>
<span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">IndentBraces</span></code> Indent the wrapped braces themselves.</p>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">SplitEmptyFunction</span></code> If <code class="docutils literal notranslate"><span class="pre">false</span></code>, empty function body can be put on a single line.
This option is used only if the opening brace of the function has
already been wrapped, i.e. the <cite>AfterFunction</cite> brace wrapping mode is
set, and the function could/should not be put on a single line (as per
<cite>AllowShortFunctionsOnASingleLine</cite> and constructor formatting options).</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="nf">f</span><span class="p">()</span>   <span class="n">vs</span><span class="p">.</span>   <span class="n">inf</span> <span class="n">f</span><span class="p">()</span>
<span class="p">{}</span>              <span class="p">{</span>
                <span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">SplitEmptyRecord</span></code> If <code class="docutils literal notranslate"><span class="pre">false</span></code>, empty record (e.g. class, struct or union) body
can be put on a single line. This option is used only if the opening
brace of the record has already been wrapped, i.e. the <cite>AfterClass</cite>
(for classes) brace wrapping mode is set.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">class</span> <span class="nc">Foo</span>   <span class="n">vs</span><span class="p">.</span>  <span class="k">class</span> <span class="nc">Foo</span>
<span class="p">{}</span>               <span class="p">{</span>
                 <span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><code class="docutils literal notranslate"><span class="pre">bool</span> <span class="pre">SplitEmptyNamespace</span></code> If <code class="docutils literal notranslate"><span class="pre">false</span></code>, empty namespace body can be put on a single line.
This option is used only if the opening brace of the namespace has
already been wrapped, i.e. the <cite>AfterNamespace</cite> brace wrapping mode is
set.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">Foo</span>   <span class="n">vs</span><span class="p">.</span>  <span class="k">namespace</span> <span class="n">Foo</span>
<span class="p">{}</span>                   <span class="p">{</span>
                     <span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>


### BreakBeforeBinaryOperators
<dd><p class="first">The way to wrap binary operators.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>BOS_None</strong> (in configuration: <strong>None</strong>)
Break after operators.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">LooooooooooongType</span> <span class="n">loooooooooooooooooooooongVariable</span> <span class="o">=</span>
    <span class="n">someLooooooooooooooooongFunction</span><span class="p">();</span>

<span class="kt">bool</span> <span class="n">value</span> <span class="o">=</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span> <span class="o">+</span>
                     <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span> <span class="o">==</span>
                 <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span> <span class="o">&amp;&amp;</span>
             <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span> <span class="o">&gt;</span>
                 <span class="n">ccccccccccccccccccccccccccccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BOS_NonAssignment</strong> (in configuration: <strong>NonAssignment</strong>)
Break before operators that aren’t assignments.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">LooooooooooongType</span> <span class="n">loooooooooooooooooooooongVariable</span> <span class="o">=</span>
    <span class="n">someLooooooooooooooooongFunction</span><span class="p">();</span>

<span class="kt">bool</span> <span class="n">value</span> <span class="o">=</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                     <span class="o">+</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                 <span class="o">==</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
             <span class="o">&amp;&amp;</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                    <span class="o">&gt;</span> <span class="n">ccccccccccccccccccccccccccccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BOS_All</strong> (in configuration: <strong>All</strong>)
Break before operators.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">LooooooooooongType</span> <span class="n">loooooooooooooooooooooongVariable</span>
    <span class="o">=</span> <span class="n">someLooooooooooooooooongFunction</span><span class="p">();</span>

<span class="kt">bool</span> <span class="n">value</span> <span class="o">=</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                     <span class="o">+</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                 <span class="o">==</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
             <span class="o">&amp;&amp;</span> <span class="n">aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa</span>
                    <span class="o">&gt;</span> <span class="n">ccccccccccccccccccccccccccccccccccccccccc</span><span class="p">;</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### BreakBeforeBraces
<dd><p class="first">The brace breaking style to use.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>BS_Attach</strong> (in configuration: <strong>Attach</strong>)
Always attach braces to surrounding context.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span> <span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span> <span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span> <span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span> <span class="p">{</span>
  <span class="k">try</span> <span class="p">{</span>
    <span class="k">do</span> <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span> <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span> <span class="k">catch</span> <span class="p">(...)</span> <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span> <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Linux</strong> (in configuration: <strong>Linux</strong>)
Like <strong>Attach</strong>, but break before braces on function, namespace and
class definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span>
<span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span> <span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span>
<span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span> <span class="p">{</span>
    <span class="k">do</span> <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span> <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span> <span class="k">catch</span> <span class="p">(...)</span> <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Mozilla</strong> (in configuration: <strong>Mozilla</strong>)
Like <strong>Attach</strong>, but break before braces on enum, function, and record
definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span> <span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span>
<span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span>
<span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span> <span class="p">{</span>
    <span class="k">do</span> <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span> <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span> <span class="k">catch</span> <span class="p">(...)</span> <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Stroustrup</strong> (in configuration: <strong>Stroustrup</strong>)
Like <strong>Attach</strong>, but break before function definitions, <strong>catch</strong>, and
<strong>else</strong>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span> <span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span> <span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span> <span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span> <span class="p">{</span>
    <span class="k">do</span> <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span> <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span>
  <span class="k">catch</span> <span class="p">(...)</span> <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span>
  <span class="k">else</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Allman</strong> (in configuration: <strong>Allman</strong>)
Always break before braces.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span>
<span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span>
<span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span>
<span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span>
  <span class="p">{</span>
    <span class="k">do</span>
    <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span>
      <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span>
      <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span>
      <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span>
  <span class="k">catch</span> <span class="p">(...)</span>
  <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
  <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span>
  <span class="k">else</span>
  <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Whitesmiths</strong> (in configuration: <strong>Whitesmiths</strong>)
Like <strong>Allman</strong> but always indent braces and line up code with braces.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span>
  <span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span>
  <span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
  <span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span>
  <span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
  <span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
  <span class="p">{</span>
  <span class="k">try</span>
    <span class="p">{</span>
    <span class="k">do</span>
      <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span>
        <span class="p">{</span>
        <span class="k">case</span> <span class="mi">1</span><span class="o">:</span>
        <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
        <span class="p">}</span>
        <span class="k">default</span><span class="o">:</span>
        <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
        <span class="p">}</span>
        <span class="p">}</span>
      <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
    <span class="p">}</span>
  <span class="k">catch</span> <span class="p">(...)</span>
    <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
    <span class="p">}</span>
  <span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
  <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
    <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
    <span class="p">}</span>
  <span class="k">else</span>
    <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
    <span class="p">}</span>
  <span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
  <span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_GNU</strong> (in configuration: <strong>GNU</strong>)
Always break before braces and add an extra level of indentation to
braces of control statements, not to those of class, function
or other definitions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span>
<span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span>
<span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span>
<span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span>
    <span class="p">{</span>
      <span class="k">do</span>
        <span class="p">{</span>
          <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span>
            <span class="p">{</span>
            <span class="k">case</span> <span class="mi">1</span><span class="o">:</span>
              <span class="p">{</span>
                <span class="n">foobar</span><span class="p">();</span>
                <span class="k">break</span><span class="p">;</span>
              <span class="p">}</span>
            <span class="k">default</span><span class="o">:</span>
              <span class="p">{</span>
                <span class="k">break</span><span class="p">;</span>
              <span class="p">}</span>
            <span class="p">}</span>
        <span class="p">}</span>
      <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
      <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
    <span class="p">}</span>
  <span class="k">catch</span> <span class="p">(...)</span>
    <span class="p">{</span>
      <span class="n">handleError</span><span class="p">();</span>
      <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
    <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span>
    <span class="p">{</span>
      <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
    <span class="p">}</span>
  <span class="k">else</span>
    <span class="p">{</span>
      <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
    <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_WebKit</strong> (in configuration: <strong>WebKit</strong>)
Like <strong>Attach</strong>, but break before functions.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">N</span> <span class="p">{</span>
<span class="k">enum</span> <span class="nc">E</span> <span class="p">{</span>
  <span class="n">E1</span><span class="p">,</span>
  <span class="n">E2</span><span class="p">,</span>
<span class="p">};</span>

<span class="k">class</span> <span class="nc">C</span> <span class="p">{</span>
<span class="k">public</span><span class="o">:</span>
  <span class="n">C</span><span class="p">();</span>
<span class="p">};</span>

<span class="kt">bool</span> <span class="nf">baz</span><span class="p">(</span><span class="kt">int</span> <span class="n">i</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">try</span> <span class="p">{</span>
    <span class="k">do</span> <span class="p">{</span>
      <span class="k">switch</span> <span class="p">(</span><span class="n">i</span><span class="p">)</span> <span class="p">{</span>
      <span class="k">case</span> <span class="mi">1</span><span class="o">:</span> <span class="p">{</span>
        <span class="n">foobar</span><span class="p">();</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="k">default</span><span class="o">:</span> <span class="p">{</span>
        <span class="k">break</span><span class="p">;</span>
      <span class="p">}</span>
      <span class="p">}</span>
    <span class="p">}</span> <span class="k">while</span> <span class="p">(</span><span class="o">--</span><span class="n">i</span><span class="p">);</span>
    <span class="k">return</span> <span class="nb">true</span><span class="p">;</span>
  <span class="p">}</span> <span class="k">catch</span> <span class="p">(...)</span> <span class="p">{</span>
    <span class="n">handleError</span><span class="p">();</span>
    <span class="k">return</span> <span class="nb">false</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">foo</span><span class="p">(</span><span class="kt">bool</span> <span class="n">b</span><span class="p">)</span>
<span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="n">b</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">2</span><span class="p">);</span>
  <span class="p">}</span> <span class="k">else</span> <span class="p">{</span>
    <span class="n">baz</span><span class="p">(</span><span class="mi">5</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>

<span class="kt">void</span> <span class="nf">bar</span><span class="p">()</span> <span class="p">{</span> <span class="n">foo</span><span class="p">(</span><span class="nb">true</span><span class="p">);</span> <span class="p">}</span>
<span class="p">}</span> <span class="c1">// namespace N</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>BS_Custom</strong> (in configuration: <strong>Custom</strong>)
Configure each individual brace in <cite>BraceWrapping</cite>.</p>
</li>
</ul>
</dd>

### BreakBeforeTernaryOperators
<dd><p class="first">If <strong>true</strong>, ternary operators will be placed after line breaks.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongDescription</span>
    <span class="o">?</span> <span class="nl">firstValue</span>
    <span class="p">:</span> <span class="n">SecondValueVeryVeryVeryVeryLong</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongDescription</span> <span class="o">?</span>
    <span class="nl">firstValue</span> <span class="p">:</span>
    <span class="n">SecondValueVeryVeryVeryVeryLong</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### BreakAfterJavaFieldAnnotations
<dd><p class="first">Break after each annotation on a field in Java files.</p>
<div class="last highlight-java notranslate"><div class="highlight"><pre><span></span><span class="kc">true</span><span class="p">:</span>                                  <span class="kc">false</span><span class="p">:</span>
<span class="nd">@Partial</span>                       <span class="n">vs</span><span class="p">.</span>     <span class="nd">@Partial</span> <span class="nd">@Mock</span> <span class="n">DataLoad</span> <span class="n">loader</span><span class="p">;</span>
<span class="nd">@Mock</span>
<span class="n">DataLoad</span> <span class="n">loader</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### BreakStringLiterals
<dd><p class="first">Allow breaking string literals when formatting.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="k">const</span> <span class="kt">char</span><span class="o">*</span> <span class="n">x</span> <span class="o">=</span> <span class="s">&quot;veryVeryVeryVeryVeryVe&quot;</span>
                <span class="s">&quot;ryVeryVeryVeryVeryVery&quot;</span>
                <span class="s">&quot;VeryLongString&quot;</span><span class="p">;</span>

<span class="nb">false</span><span class="o">:</span>
<span class="k">const</span> <span class="kt">char</span><span class="o">*</span> <span class="n">x</span> <span class="o">=</span>
  <span class="s">&quot;veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongString&quot;</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### ColumnLimit
<dd><p class="first">The column limit.</p>
<p class="last">A column limit of <strong>0</strong> means that there is no column limit. In this case,
clang-format will respect the input’s line breaking decisions within
statements unless they contradict other rules.</p>
</dd>

### CommentPragmas
<dd><p class="first">A regular expression that describes comments with special meaning,
which should not be split into lines or otherwise changed.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="c1">// CommentPragmas: &#39;^ FOOBAR pragma:&#39;</span>
<span class="c1">// Will leave the following line unaffected</span>
<span class="cp">#include</span> <span class="cpf">&lt;vector&gt;</span><span class="c1"> // FOOBAR pragma: keep</span><span class="cp"></span>
</pre></div>
</div>
</dd>

### ConstructorInitializerAllOnOneLineOrOnePerLine
<dd>This option is <strong>deprecated</strong>. See <strong>CurrentLine</strong> of
<strong>PackConstructorInitializers</strong>.</dd>

### ConstructorInitializerIndentWidth
<dd>The number of characters to use for indentation of constructor
initializer lists as well as inheritance lists.</dd>

### ContinuationIndentWidth
<dd><p class="first">Indent width for line continuations.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">ContinuationIndentWidth</span><span class="p">:</span> <span class="mi">2</span>

<span class="kt">int</span> <span class="n">i</span> <span class="o">=</span>         <span class="c1">//  VeryVeryVeryVeryVeryLongComment</span>
  <span class="n">longFunction</span><span class="p">(</span> <span class="c1">// Again a long comment</span>
    <span class="n">arg</span><span class="p">);</span>
</pre></div>
</div>
</dd>

### Cpp11BracedListStyle
<dd><p class="first">If <strong>true</strong>, format braced lists as best suited for C++11 braced
lists.</p>
<p>Important differences:
- No spaces inside the braced list.
- No line break before the closing brace.
- Indentation with the continuation indent, not with the block indent.</p>
<p>Fundamentally, C++11 braced lists are formatted exactly like function
calls would be formatted in their place. If the braced list follows a name
(e.g. a type or variable name), clang-format formats as if the <strong>{}</strong> were
the parentheses of a function call with that name. If there is no name,
a zero-length name is assumed.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="n">vector</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;</span> <span class="n">x</span><span class="p">{</span><span class="mi">1</span><span class="p">,</span> <span class="mi">2</span><span class="p">,</span> <span class="mi">3</span><span class="p">,</span> <span class="mi">4</span><span class="p">};</span>     <span class="n">vs</span><span class="p">.</span>     <span class="n">vector</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;</span> <span class="n">x</span><span class="p">{</span> <span class="mi">1</span><span class="p">,</span> <span class="mi">2</span><span class="p">,</span> <span class="mi">3</span><span class="p">,</span> <span class="mi">4</span> <span class="p">};</span>
<span class="n">vector</span><span class="o">&lt;</span><span class="n">T</span><span class="o">&gt;</span> <span class="n">x</span><span class="p">{{},</span> <span class="p">{},</span> <span class="p">{},</span> <span class="p">{}};</span>           <span class="n">vector</span><span class="o">&lt;</span><span class="n">T</span><span class="o">&gt;</span> <span class="n">x</span><span class="p">{</span> <span class="p">{},</span> <span class="p">{},</span> <span class="p">{},</span> <span class="p">{}</span> <span class="p">};</span>
<span class="n">f</span><span class="p">(</span><span class="n">MyMap</span><span class="p">[{</span><span class="n">composite</span><span class="p">,</span> <span class="n">key</span><span class="p">}]);</span>            <span class="n">f</span><span class="p">(</span><span class="n">MyMap</span><span class="p">[{</span> <span class="n">composite</span><span class="p">,</span> <span class="n">key</span> <span class="p">}]);</span>
<span class="k">new</span> <span class="kt">int</span><span class="p">[</span><span class="mi">3</span><span class="p">]{</span><span class="mi">1</span><span class="p">,</span> <span class="mi">2</span><span class="p">,</span> <span class="mi">3</span><span class="p">};</span>                   <span class="k">new</span> <span class="kt">int</span><span class="p">[</span><span class="mi">3</span><span class="p">]{</span> <span class="mi">1</span><span class="p">,</span> <span class="mi">2</span><span class="p">,</span> <span class="mi">3</span> <span class="p">};</span>
</pre></div>
</div>
</dd>

### DerivePointerAlignment
<dd>If <strong>true</strong>, analyze the formatted file for the most common
alignment of <strong>&amp;</strong> and <strong>*</strong>.
Pointer and reference alignment styles are going to be updated according
to the preferences found in the file.
<strong>PointerAlignment</strong> is then used only as fallback.</dd>

### DisableFormat
<dd>Disables formatting completely.</dd>

### ForEachMacros
<dd><p class="first">A vector of macros that should be interpreted as foreach loops
instead of as function calls.</p>
<p>These are expected to be macros of the form:</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">FOREACH</span><span class="p">(</span><span class="o">&lt;</span><span class="n">variable</span><span class="o">-</span><span class="n">declaration</span><span class="o">&gt;</span><span class="p">,</span> <span class="p">...)</span>
  <span class="o">&lt;</span><span class="n">loop</span><span class="o">-</span><span class="n">body</span><span class="o">&gt;</span>
</pre></div>
</div>
<p>In the .clang-format configuration file, this can be configured like:</p>
<div class="highlight-yaml notranslate"><div class="highlight"><pre><span></span><span class="nt">ForEachMacros</span><span class="p">:</span> <span class="p p-Indicator">[</span><span class="s">&#39;RANGES_FOR&#39;</span><span class="p p-Indicator">,</span> <span class="s">&#39;FOREACH&#39;</span><span class="p p-Indicator">]</span>
</pre></div>
</div>
<p class="last">For example: BOOST_FOREACH.</p>
</dd>

### IncludeCategories
<dd><p class="first">Regular expressions denoting the different <code class="docutils literal notranslate"><span class="pre">#include</span></code> categories
used for ordering <code class="docutils literal notranslate"><span class="pre">#includes</span></code>.</p>
<p><a class="reference external" href="http://pubs.opengroup.org/onlinepubs/9699919799/basedefs/V1_chap09.html">POSIX extended</a>
regular expressions are supported.</p>
<p>These regular expressions are matched against the filename of an include
(including the &lt;&gt; or “”) in order. The value belonging to the first
matching regular expression is assigned and <code class="docutils literal notranslate"><span class="pre">#includes</span></code> are sorted first
according to increasing category number and then alphabetically within
each category.</p>
<p>If none of the regular expressions match, INT_MAX is assigned as
category. The main header for a source file automatically gets category 0.
so that it is generally kept at the beginning of the <code class="docutils literal notranslate"><span class="pre">#includes</span></code>
(<a class="reference external" href="https://llvm.org/docs/CodingStandards.html#include-style">https://llvm.org/docs/CodingStandards.html#include-style</a>). However, you
can also assign negative priorities if you have certain headers that
always need to be first.</p>
<p>To configure this in the .clang-format file, use:</p>
<div class="last highlight-yaml notranslate"><div class="highlight"><pre><span></span><span class="l l-Scalar l-Scalar-Plain">IncludeCategories</span><span class="p p-Indicator">:</span>
  <span class="p p-Indicator">-</span> <span class="l l-Scalar l-Scalar-Plain">Regex</span><span class="p p-Indicator">:</span>           <span class="s">&#39;^&quot;(llvm|llvm-c|clang|clang-c)/&#39;</span>
    <span class="l l-Scalar l-Scalar-Plain">Priority</span><span class="p p-Indicator">:</span>        <span class="l l-Scalar l-Scalar-Plain">2</span>
  <span class="p p-Indicator">-</span> <span class="l l-Scalar l-Scalar-Plain">Regex</span><span class="p p-Indicator">:</span>           <span class="s">&#39;^(&lt;|&quot;(gtest|gmock|isl|json)/)&#39;</span>
    <span class="l l-Scalar l-Scalar-Plain">Priority</span><span class="p p-Indicator">:</span>        <span class="l l-Scalar l-Scalar-Plain">3</span>
  <span class="p p-Indicator">-</span> <span class="l l-Scalar l-Scalar-Plain">Regex</span><span class="p p-Indicator">:</span>           <span class="s">&#39;&lt;[[:alnum:].]+&gt;&#39;</span>
    <span class="l l-Scalar l-Scalar-Plain">Priority</span><span class="p p-Indicator">:</span>        <span class="l l-Scalar l-Scalar-Plain">4</span>
  <span class="p p-Indicator">-</span> <span class="l l-Scalar l-Scalar-Plain">Regex</span><span class="p p-Indicator">:</span>           <span class="s">&#39;.*&#39;</span>
    <span class="l l-Scalar l-Scalar-Plain">Priority</span><span class="p p-Indicator">:</span>        <span class="l l-Scalar l-Scalar-Plain">1</span>
</pre></div>
</div>
</dd>


### IndentCaseLabels
<dd><p class="first">Indent case labels one level from the switch statement.</p>
<p>When <strong>false</strong>, use the same indentation level as for the switch
statement. Switch statement body is always indented one level more than
case labels (except the first block following the case label, which
itself indents the code - unless IndentCaseBlocks is enabled).</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">false</span><span class="o">:</span>                                 <span class="nb">true</span><span class="o">:</span>
<span class="k">switch</span> <span class="p">(</span><span class="n">fool</span><span class="p">)</span> <span class="p">{</span>                <span class="n">vs</span><span class="p">.</span>     <span class="k">switch</span> <span class="p">(</span><span class="n">fool</span><span class="p">)</span> <span class="p">{</span>
<span class="k">case</span> <span class="mi">1</span><span class="o">:</span>                                  <span class="k">case</span> <span class="mi">1</span><span class="o">:</span>
  <span class="n">bar</span><span class="p">();</span>                                   <span class="n">bar</span><span class="p">();</span>
  <span class="k">break</span><span class="p">;</span>                                   <span class="k">break</span><span class="p">;</span>
<span class="k">default</span><span class="o">:</span>                                 <span class="k">default</span><span class="o">:</span>
  <span class="n">plop</span><span class="p">();</span>                                  <span class="n">plop</span><span class="p">();</span>
<span class="p">}</span>                                      <span class="p">}</span>
</pre></div>
</div>
</dd>

### IndentWidth
<dd><p class="first">The number of columns to use for indentation.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">IndentWidth</span><span class="p">:</span> <span class="mi">3</span>

<span class="kt">void</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>
   <span class="n">someFunction</span><span class="p">();</span>
   <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">,</span> <span class="nb">false</span><span class="p">)</span> <span class="p">{</span>
      <span class="n">f</span><span class="p">();</span>
   <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</dd>

### IndentWrappedFunctionNames
<dd><p class="first">Indent if a function definition or declaration is wrapped after the
type.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>
<span class="n">LoooooooooooooooooooooooooooooooooooooooongReturnType</span>
    <span class="n">LoooooooooooooooooooooooooooooooongFunctionDeclaration</span><span class="p">();</span>

<span class="nb">false</span><span class="o">:</span>
<span class="n">LoooooooooooooooooooooooooooooooooooooooongReturnType</span>
<span class="n">LoooooooooooooooooooooooooooooooongFunctionDeclaration</span><span class="p">();</span>
</pre></div>
</div>
</dd>

### KeepEmptyLinesAtTheStartOfBlocks
<dd><p class="first">If true, the empty line at the start of blocks is kept.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">)</span> <span class="p">{</span>                     <span class="n">vs</span><span class="p">.</span>     <span class="k">if</span> <span class="p">(</span><span class="n">foo</span><span class="p">)</span> <span class="p">{</span>
                                         <span class="n">bar</span><span class="p">();</span>
  <span class="n">bar</span><span class="p">();</span>                               <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</dd>

### MacroBlockBegin
<dd><p class="first">A regular expression matching macros that start a block.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp"># With:</span>
<span class="nl">MacroBlockBegin</span><span class="p">:</span> <span class="s">&quot;^NS_MAP_BEGIN|\</span>
<span class="s">NS_TABLE_HEAD$&quot;</span>
<span class="nl">MacroBlockEnd</span><span class="p">:</span> <span class="s">&quot;^\</span>
<span class="s">NS_MAP_END|\</span>
<span class="s">NS_TABLE_.*_END$&quot;</span>

<span class="n">NS_MAP_BEGIN</span>
  <span class="n">foo</span><span class="p">();</span>
<span class="n">NS_MAP_END</span>

<span class="n">NS_TABLE_HEAD</span>
  <span class="n">bar</span><span class="p">();</span>
<span class="n">NS_TABLE_FOO_END</span>

<span class="cp"># Without:</span>
<span class="n">NS_MAP_BEGIN</span>
<span class="n">foo</span><span class="p">();</span>
<span class="n">NS_MAP_END</span>

<span class="n">NS_TABLE_HEAD</span>
<span class="n">bar</span><span class="p">();</span>
<span class="n">NS_TABLE_FOO_END</span>
</pre></div>
</div>
</dd>

### MacroBlockEnd
<dd>A regular expression matching macros that end a block.</dd>

### MaxEmptyLinesToKeep
<dd><p class="first">The maximum number of consecutive empty lines to keep.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">MaxEmptyLinesToKeep</span><span class="p">:</span> <span class="mi">1</span>         <span class="n">vs</span><span class="p">.</span>     <span class="nl">MaxEmptyLinesToKeep</span><span class="p">:</span> <span class="mi">0</span>
<span class="kt">int</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>                              <span class="kt">int</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>                                 <span class="kt">int</span> <span class="n">i</span> <span class="o">=</span> <span class="mi">1</span><span class="p">;</span>
                                           <span class="n">i</span> <span class="o">=</span> <span class="n">foo</span><span class="p">();</span>
  <span class="n">i</span> <span class="o">=</span> <span class="n">foo</span><span class="p">();</span>                               <span class="k">return</span> <span class="n">i</span><span class="p">;</span>
                                       <span class="p">}</span>
  <span class="k">return</span> <span class="n">i</span><span class="p">;</span>
<span class="p">}</span>
</pre></div>
</div>
</dd>

### NamespaceIndentation
<dd><p class="first">The indentation used for namespaces.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>NI_None</strong> (in configuration: <strong>None</strong>)
Don’t indent in namespaces.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">out</span> <span class="p">{</span>
<span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
<span class="k">namespace</span> <span class="n">in</span> <span class="p">{</span>
<span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
<span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>NI_Inner</strong> (in configuration: <strong>Inner</strong>)
Indent only in inner namespaces (nested in other namespaces).</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">out</span> <span class="p">{</span>
<span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
<span class="k">namespace</span> <span class="n">in</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
<span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>NI_All</strong> (in configuration: <strong>All</strong>)
Indent in all namespaces.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">namespace</span> <span class="n">out</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
  <span class="k">namespace</span> <span class="n">in</span> <span class="p">{</span>
    <span class="kt">int</span> <span class="n">i</span><span class="p">;</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### ObjCBlockIndentWidth
<dd><p class="first">The number of characters to use for indentation of ObjC blocks.</p>
<div class="last highlight-objc notranslate"><div class="highlight"><pre><span></span><span class="nl">ObjCBlockIndentWidth</span><span class="p">:</span> <span class="mi">4</span>

<span class="p">[</span><span class="n">operation</span> <span class="nl">setCompletionBlock</span><span class="p">:</span><span class="o">^</span><span class="p">{</span>
    <span class="p">[</span><span class="nb">self</span> <span class="n">onOperationDone</span><span class="p">];</span>
<span class="p">}];</span>
</pre></div>
</div>
</dd>

### ObjCSpaceAfterProperty
<dd>Add a space after <strong>&#64;property</strong> in Objective-C, i.e. use
<strong>&#64;property</span> <span class="pre">(readonly)</strong> instead of <strong>&#64;property(readonly)</strong>.</dd>

### ObjCSpaceBeforeProtocolList
<dd>Add a space in front of an Objective-C protocol list, i.e. use
<strong>Foo</span> <span class="pre">&lt;Protocol&gt;</strong> instead of <strong>Foo&lt;Protocol&gt;</strong>.</dd>

### PenaltyBreakBeforeFirstCallParameter
<dd>The penalty for breaking a function call after <strong>call(</strong>.</dd>

### PenaltyBreakComment
<dd>The penalty for each line break introduced inside a comment.</dd>

### PenaltyBreakFirstLessLess
<dd>The penalty for breaking before the first <strong>&lt;&lt;</strong>.</dd>

### PenaltyBreakString
<dd>The penalty for each line break introduced inside a string literal.</dd>

### PenaltyExcessCharacter
<dd>The penalty for each character outside of the column limit.</dd>

### PenaltyReturnTypeOnItsOwnLine
<dd>Penalty for putting the return type of a function onto its own
line.</dd>

### PointerAlignment
<dd><p class="first">Pointer and reference alignment style.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>PAS_Left</strong> (in configuration: <strong>Left</strong>)
Align pointer to the left.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span><span class="o">*</span> <span class="n">a</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>PAS_Right</strong> (in configuration: <strong>Right</strong>)
Align pointer to the right.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="o">*</span><span class="n">a</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>PAS_Middle</strong> (in configuration: <strong>Middle</strong>)
Align pointer in the middle.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">int</span> <span class="o">*</span> <span class="n">a</span><span class="p">;</span>
</pre></div>
</div>
</li>
</ul>
</dd>

### ReflowComments
<dd><p class="first">If <strong>true</strong>, clang-format will attempt to re-flow comments.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">false</span><span class="o">:</span>
<span class="c1">// veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongComment with plenty of information</span>
<span class="cm">/* second veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongComment with plenty of information */</span>

<span class="nb">true</span><span class="o">:</span>
<span class="c1">// veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongComment with plenty of</span>
<span class="c1">// information</span>
<span class="cm">/* second veryVeryVeryVeryVeryVeryVeryVeryVeryVeryVeryLongComment with plenty of</span>
<span class="cm"> * information */</span>
</pre></div>
</div>
</dd>

### SortIncludes
<dd><p class="first">Controls if and how clang-format will sort <strong>#includes</strong>.
If <strong>Never</strong>, includes are never sorted.
If <strong>CaseInsensitive</strong>, includes are sorted in an ASCIIbetical or case
insensitive fashion.
If <strong>CaseSensitive</strong>, includes are sorted in an alphabetical or case
sensitive fashion.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SI_Never</strong> (in configuration: <strong>Never</strong>)
Includes are never sorted.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp">#include</span> <span class="cpf">&quot;B/A.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;A/B.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;a/b.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;A/b.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;B/a.h&quot;</span><span class="cp"></span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SI_CaseSensitive</strong> (in configuration: <strong>CaseSensitive</strong>)
Includes are sorted in an ASCIIbetical or case sensitive fashion.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp">#include</span> <span class="cpf">&quot;A/B.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;A/b.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;B/A.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;B/a.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;a/b.h&quot;</span><span class="cp"></span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SI_CaseInsensitive</strong> (in configuration: <strong>CaseInsensitive</strong>)
Includes are sorted in an alphabetical or case insensitive fashion.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="cp">#include</span> <span class="cpf">&quot;A/B.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;A/b.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;a/b.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;B/A.h&quot;</span><span class="cp"></span>
<span class="cp">#include</span> <span class="cpf">&quot;B/a.h&quot;</span><span class="cp"></span>
</pre></div>
</div>
</li>
</ul>
</dd>

### SpaceAfterCStyleCast
<dd><p class="first">If <strong>true</strong>, a space is inserted after C style casts.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="p">(</span><span class="kt">int</span><span class="p">)</span> <span class="n">i</span><span class="p">;</span>                       <span class="n">vs</span><span class="p">.</span>     <span class="p">(</span><span class="kt">int</span><span class="p">)</span><span class="n">i</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### SpaceBeforeAssignmentOperators
<dd><p class="first">If <strong>false</strong>, spaces will be removed before assignment operators.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span> <span class="o">=</span> <span class="mi">5</span><span class="p">;</span>                     <span class="n">vs</span><span class="p">.</span>     <span class="kt">int</span> <span class="n">a</span><span class="o">=</span> <span class="mi">5</span><span class="p">;</span>
<span class="n">a</span> <span class="o">+=</span> <span class="mi">42</span><span class="p">;</span>                               <span class="n">a</span><span class="o">+=</span> <span class="mi">42</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### SpaceBeforeParens
<dd><p class="first">Defines in which cases to put a space before opening parentheses.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SBPO_Never</strong> (in configuration: <strong>Never</strong>)
Never put a space before opening parentheses.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">if</span><span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">f</span><span class="p">();</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBPO_ControlStatements</strong> (in configuration: <strong>ControlStatements</strong>)
Put a space before opening parentheses only after control statement
keywords (<strong>for/if/while...</strong>).</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">f</span><span class="p">();</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBPO_ControlStatementsExceptControlMacros</strong> (in configuration: <strong>ControlStatementsExceptControlMacros</strong>)
Same as <strong>SBPO_ControlStatements</strong> except this option doesn’t apply to
ForEach and If macros. This is useful in projects where ForEach/If
macros are treated as function calls instead of control statements.
<strong>SBPO_ControlStatementsExceptForEachMacros</strong> remains an alias for
backward compatibility.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span> <span class="nf">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="n">Q_FOREACH</span><span class="p">(...)</span> <span class="p">{</span>
    <span class="n">f</span><span class="p">();</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBPO_NonEmptyParentheses</strong> (in configuration: <strong>NonEmptyParentheses</strong>)
Put a space before opening parentheses only if the parentheses are not
empty i.e. ‘()’</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">f</span><span class="p">();</span>
    <span class="n">g</span> <span class="p">(</span><span class="n">x</span><span class="p">,</span> <span class="n">y</span><span class="p">,</span> <span class="n">z</span><span class="p">);</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBPO_Always</strong> (in configuration: <strong>Always</strong>)
Always put a space before opening parentheses, except when it’s
prohibited by the syntax rules (in function-like macro definitions) or
when determined by other style rules (after unary operators, opening
parentheses, etc.)</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="kt">void</span> <span class="nf">f</span> <span class="p">()</span> <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">f</span> <span class="p">();</span>
  <span class="p">}</span>
<span class="p">}</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SBPO_Custom</strong> (in configuration: <strong>Custom</strong>)
Configure each individual space before parentheses in
<cite>SpaceBeforeParensOptions</cite>.</p>
</li>
</ul>
</dd>

### SpaceInEmptyParentheses
<dd><p class="first">If <strong>true</strong>, spaces may be inserted into <strong>()</strong>.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                <span class="nb">false</span><span class="o">:</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">(</span> <span class="p">)</span> <span class="p">{</span>                    <span class="n">vs</span><span class="p">.</span>   <span class="kt">void</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="kt">int</span> <span class="n">x</span><span class="p">[]</span> <span class="o">=</span> <span class="p">{</span><span class="n">foo</span><span class="p">(</span> <span class="p">),</span> <span class="n">bar</span><span class="p">(</span> <span class="p">)};</span>          <span class="kt">int</span> <span class="n">x</span><span class="p">[]</span> <span class="o">=</span> <span class="p">{</span><span class="n">foo</span><span class="p">(),</span> <span class="n">bar</span><span class="p">()};</span>
  <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>                          <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>
    <span class="n">f</span><span class="p">(</span> <span class="p">);</span>                                <span class="n">f</span><span class="p">();</span>
  <span class="p">}</span>                                    <span class="p">}</span>
<span class="p">}</span>                                    <span class="p">}</span>
</pre></div>
</div>
</dd>

### SpacesBeforeTrailingComments
<dd><p class="first">The number of spaces before trailing line comments
(<strong>//</strong> - comments).</p>
<p>This does not affect trailing block comments (<strong>/*</strong> - comments) as
those commonly have different usage patterns and a number of special
cases.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nl">SpacesBeforeTrailingComments</span><span class="p">:</span> <span class="mi">3</span>
<span class="kt">void</span> <span class="n">f</span><span class="p">()</span> <span class="p">{</span>
  <span class="k">if</span> <span class="p">(</span><span class="nb">true</span><span class="p">)</span> <span class="p">{</span>   <span class="c1">// foo1</span>
    <span class="n">f</span><span class="p">();</span>        <span class="c1">// bar</span>
  <span class="p">}</span>             <span class="c1">// foo</span>
<span class="p">}</span>
</pre></div>
</div>
</dd>

### SpacesInAngles
<dd><p class="first">The SpacesInAnglesStyle to use for template argument lists.</p>
<p>Possible values:</p>
<ul class="last">
<li><p class="first"><strong>SIAS_Never</strong> (in configuration: <strong>Never</strong>)
Remove spaces after <strong>&lt;</strong> and before <strong>&gt;</strong>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">static_cast</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;</span><span class="p">(</span><span class="n">arg</span><span class="p">);</span>
<span class="n">std</span><span class="o">::</span><span class="n">function</span><span class="o">&lt;</span><span class="kt">void</span><span class="p">(</span><span class="kt">int</span><span class="p">)</span><span class="o">&gt;</span> <span class="n">fct</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SIAS_Always</strong> (in configuration: <strong>Always</strong>)
Add spaces after <strong>&lt;</strong> and before <strong>&gt;</strong>.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="k">static_cast</span><span class="o">&lt;</span> <span class="kt">int</span> <span class="o">&gt;</span><span class="p">(</span><span class="n">arg</span><span class="p">);</span>
<span class="n">std</span><span class="o">::</span><span class="n">function</span><span class="o">&lt;</span> <span class="kt">void</span><span class="p">(</span><span class="kt">int</span><span class="p">)</span> <span class="o">&gt;</span> <span class="n">fct</span><span class="p">;</span>
</pre></div>
</div>
</li>
<li><p class="first"><strong>SIAS_Leave</strong> (in configuration: <strong>Leave</strong>)
Keep a single space after <strong>&lt;</strong> and before <strong>&gt;</strong> if any spaces were
present. Option <strong>Standard:</span> <span class="pre">Cpp03</strong> takes precedence.</p>
</li>
</ul>
</dd>

### SpacesInContainerLiterals
<dd><p class="first">If <strong>true</strong>, spaces are inserted inside container literals (e.g.
ObjC and Javascript array and dict literals).</p>
<div class="last highlight-js notranslate"><div class="highlight"><pre><span></span><span class="kc">true</span><span class="o">:</span>                                  <span class="kc">false</span><span class="o">:</span>
<span class="kd">var</span> <span class="nx">arr</span> <span class="o">=</span> <span class="p">[</span> <span class="mf">1</span><span class="p">,</span> <span class="mf">2</span><span class="p">,</span> <span class="mf">3</span> <span class="p">];</span>         <span class="nx">vs</span><span class="p">.</span>     <span class="kd">var</span> <span class="nx">arr</span> <span class="o">=</span> <span class="p">[</span><span class="mf">1</span><span class="p">,</span> <span class="mf">2</span><span class="p">,</span> <span class="mf">3</span><span class="p">];</span>
<span class="nx">f</span><span class="p">({</span><span class="nx">a</span> <span class="o">:</span> <span class="mf">1</span><span class="p">,</span> <span class="nx">b</span> <span class="o">:</span> <span class="mf">2</span><span class="p">,</span> <span class="nx">c</span> <span class="o">:</span> <span class="mf">3</span><span class="p">});</span>              <span class="nx">f</span><span class="p">({</span><span class="nx">a</span><span class="o">:</span> <span class="mf">1</span><span class="p">,</span> <span class="nx">b</span><span class="o">:</span> <span class="mf">2</span><span class="p">,</span> <span class="nx">c</span><span class="o">:</span> <span class="mf">3</span><span class="p">});</span>
</pre></div>
</div>
</dd>

### SpacesInCStyleCastParentheses
<dd><p class="first">If <strong>true</strong>, spaces may be inserted into C style casts.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="n">x</span> <span class="o">=</span> <span class="p">(</span> <span class="n">int32</span> <span class="p">)</span><span class="n">y</span>                 <span class="n">vs</span><span class="p">.</span>     <span class="n">x</span> <span class="o">=</span> <span class="p">(</span><span class="n">int32</span><span class="p">)</span><span class="n">y</span>
</pre></div>
</div>
</dd>

### SpacesInParentheses
<dd><p class="first">If <strong>true</strong>, spaces will be inserted after <strong>(</strong> and before <strong>)</strong>.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="n">t</span> <span class="n">f</span><span class="p">(</span> <span class="n">Deleted</span> <span class="o">&amp;</span> <span class="p">)</span> <span class="o">&amp;</span> <span class="o">=</span> <span class="k">delete</span><span class="p">;</span>   <span class="n">vs</span><span class="p">.</span>     <span class="n">t</span> <span class="n">f</span><span class="p">(</span><span class="n">Deleted</span> <span class="o">&amp;</span><span class="p">)</span> <span class="o">&amp;</span> <span class="o">=</span> <span class="k">delete</span><span class="p">;</span>
</pre></div>
</div>
</dd>

### SpacesInSquareBrackets
<dd><p class="first">If <strong>true</strong>, spaces will be inserted after <strong>[</strong> and before <strong>]</strong>.
Lambdas without arguments or unspecified size array declarations will not
be affected.</p>
<div class="last highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="nb">true</span><span class="o">:</span>                                  <span class="nb">false</span><span class="o">:</span>
<span class="kt">int</span> <span class="n">a</span><span class="p">[</span> <span class="mi">5</span> <span class="p">];</span>                    <span class="n">vs</span><span class="p">.</span>     <span class="kt">int</span> <span class="n">a</span><span class="p">[</span><span class="mi">5</span><span class="p">];</span>
<span class="n">std</span><span class="o">::</span><span class="n">unique_ptr</span><span class="o">&lt;</span><span class="kt">int</span><span class="p">[]</span><span class="o">&gt;</span> <span class="n">foo</span><span class="p">()</span> <span class="p">{}</span> <span class="c1">// Won&#39;t be affected</span>
</pre></div>
</div>
</dd>

### Standard
<dd><p class="first">Parse and format C++ constructs compatible with this standard.</p>
<div class="highlight-c++ notranslate"><div class="highlight"><pre><span></span><span class="n">c</span><span class="o">++</span><span class="mo">03</span><span class="o">:</span>                                 <span class="nl">latest</span><span class="p">:</span>
<span class="n">vector</span><span class="o">&lt;</span><span class="n">set</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;</span> <span class="o">&gt;</span> <span class="n">x</span><span class="p">;</span>           <span class="n">vs</span><span class="p">.</span>     <span class="n">vector</span><span class="o">&lt;</span><span class="n">set</span><span class="o">&lt;</span><span class="kt">int</span><span class="o">&gt;&gt;</span> <span class="n">x</span><span class="p">;</span>
</pre></div>
</div>
<p>Possible values:</p>
<ul class="last simple">
<li><strong>LS_Cpp03</strong> (in configuration: <strong>c++03</strong>)
Parse and format as C++03.
<strong>Cpp03</strong> is a deprecated alias for <strong>c++03</strong></li>
<li><strong>LS_Cpp11</strong> (in configuration: <strong>c++11</strong>)
Parse and format as C++11.</li>
<li><strong>LS_Cpp14</strong> (in configuration: <strong>c++14</strong>)
Parse and format as C++14.</li>
<li><strong>LS_Cpp17</strong> (in configuration: <strong>c++17</strong>)
Parse and format as C++17.</li>
<li><strong>LS_Cpp20</strong> (in configuration: <strong>c++20</strong>)
Parse and format as C++20.</li>
<li><strong>LS_Latest</strong> (in configuration: <strong>Latest</strong>)
Parse and format using the latest supported language version.
<strong>Cpp11</strong> is a deprecated alias for <strong>Latest</strong></li>
<li><strong>LS_Auto</strong> (in configuration: <strong>Auto</strong>)
Automatic detection based on the input.</li>
</ul>
</dd>

### TabWidth
<dd>The number of columns used for tab stops.</dd>

### UseTab
<dd><p class="first">The way to use tab characters in the resulting file.</p>
<p>Possible values:</p>
<ul class="last simple">
<li><strong>UT_Never</strong> (in configuration: <strong>Never</strong>)
Never use tab.</li>
<li><strong>UT_ForIndentation</strong> (in configuration: <strong>ForIndentation</strong>)
Use tabs only for indentation.</li>
<li><strong>UT_ForContinuationAndIndentation</strong> (in configuration: <strong>ForContinuationAndIndentation</strong>)
Fill all leading whitespace with tabs, and use spaces for alignment that
appears within a line (e.g. consecutive assignments and declarations).</li>
<li><strong>UT_AlignWithSpaces</strong> (in configuration: <strong>AlignWithSpaces</strong>)
Use tabs for line continuation and indentation, and spaces for
alignment.</li>
<li><strong>UT_Always</strong> (in configuration: <strong>Always</strong>)
Use tabs whenever we need to fill whitespace that spans at least from
one tab stop to the next one.</li>
</ul>
</dd>

