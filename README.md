QA

This folder contains my works in software testing.
It demonstrates my skills in both manual testing and unit testing.

01_Defect_Reporting_BookUA

This project demonstrates manual testing of the Book.ua web application.
Both functional and visual defects were documented during testing.

Severity Levels

Critical: Functional issue that blocks application usage (not found)

Major: Affects application functionality but does not completely block it

Average: Less important defects, affecting user convenience

Minor: Minor visual issues

Enhancement: Suggestions for improvement

Example Defects
Headline	Severity	Description	Actual Result	Expected Result	Note
Partial interface translation	Major	Select English language	Some elements remain in Ukrainian	Entire interface should be translated into English	(See Defect_Translation.png)
Missing author biography	Average	Open author profile	Only the name is displayed	A short biography should be displayed	(See Defect_Author_Bio.png)
Missing "Home" button	Minor	Navigate back to home	Button is missing	There should be a button to return	(See Defect_Author_Bio.png)
Missing user reviews	Average	Go to "Reviews" section	Reviews are missing	Reviews from other users should be displayed	(See Defect_No_Reviews.png)
02_Unit_Testing_VideoAnalyzer

This project demonstrates unit testing in C# using MSTest.
The VideoAnalyzer class was tested, which analyzes video frames and detects motion.

Tested Methods

DetectMotion(byte[] frame1, byte[] frame2)

Returns true if frames are different

Returns false if frames are identical

IsFrameEmpty(byte[] frame)

Returns true if all bytes are zero

Returns false if at least one byte is non-zero
