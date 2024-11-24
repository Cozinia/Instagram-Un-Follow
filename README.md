
# Instagram (Un)Follow

Using JSON files provided by Instagram make a list of people who don't follow you back.

### Project's motivation

Managing social media relationships, particularly on platforms like Instagram, is increasingly important in both personal and professional contexts. People want to know who follows them back or identify accounts that they follow but do not reciprocate. This tool provides a practical solution to automate the tedious process of manually checking followers and followings, making social media management more efficient. It's a project that has immediate real-world utility for users, from influencers to businesses, or even personal account holders.

### Learning goals
1. `JSON Parsing`: The project involves handling Instagram’s exported data in JSON format, which is a widely-used format for data representation. Parsing and working with JSON files is a key skill in modern development.
2. `C# and Windows Forms`: Developing a desktop application using C# and Windows Forms allows me to explore graphical user interface (GUI) design, event-driven programming, and how to present data interactively.
3. `ListView and Dynamic UI`: Implementing dynamic components such as the ListView to display user data, including profile links, adds complexity and an interactive element to the tool, offering opportunities to improve my UI/UX development skills.

### Steps to Download Your Instagram Followers and Following Information

1. **Open Instagram**: Launch the Instagram app on your device.  
  

2. **Go to Your Profile**: Tap on your profile picture in the bottom-right corner of the app.  
   

3. **Access the Settings**:
   - Tap the **Menu (three lines)** icon in the top-right corner of your profile.
   - Select **Settings** from the dropdown menu.  
  ![1.png](/src/1.png)

4. **Navigate to the Accounts Centre**:
   - Scroll down and select **"See more in Accounts Centre"**. This will open a section that contains your account-related data.  
   ![2.png](/src/2.png)

5. **Go to Your Information and Permissions**:
   - In Accounts Centre, look for the section called **Your Information and Permissions**.
  
   - Tap **"Download your information"** to proceed. 
    ![3.png](/src/3.png) 
   
  
6. **Choose to Download or Transfer Information**:
   - On the new screen, select **Download or Transfer Your Information**.  
  ![4.png](/src/4.png)

7. **Select the Account**:
   - If you have multiple accounts, choose the one from which you want to download the data.  
   ![5.png](/src/5.png)

8. **Choose Specific Information**:
   - Tap **"Some of Your Information"** to select specific data categories.
   ![6.png](/src/6.png)
   - Scroll down and find **Connections**.
   - Under **Connections**, select **Followers and Following** to include this in the download.  
   ![7.png](/src/7.png)

9.  **Choose Download to Device**:
   - On the next screen, select **Download to Device**.  
   ![8.png](/src/8.png)

10. **Configure Date Range**:
   - You will be prompted to choose a date range. For the full history, select **All Time**.  
   ![9.png](/src/9.png)
   ![10.png](/src/10.png)

11. **Select Format**:
   - For the format, choose **JSON**. This format is structured and machine-readable, making it suitable for data processing.  
   ![11.png](/src/11.png)
   ![12.png](/src/12.png)

12. **Create Files**:
   - Tap **Create Files** to initiate the data preparation process. Instagram will send an email to your registered address with a link to download your data. This may take a few hours.  
   ![13.png](/src/13.png)

13. **Wait for the Email**:
   - Instagram will prepare the file and send an email to your registered address with a link to download your data. This may take a few hours, depending on the size of the data.
 ![14.png](/src/14.png)

14. **Press Download**:
   - After creating the files, a **Download** button will appear. Click it to download the archive containing your Instagram data.  
   ![15.png](/src/15.png)

15. **Unzip the File and Access the Data**:
   - Once you receive the file from Meta (Facebook/Instagram), unzip the downloaded archive on your device.
   - Navigate to the **Connections** folder within the unzipped files.
   - Inside the **Connections** folder, open **followers_and_following** an there you will find two files named `following.json` and `followers_1.json`.
   - These files contain the lists of people you are following (`following.json`) and people who follow you (`followers_1.json`).

### To Find Out Who is Not Following You Back:

1. **Download or Clone the Project**:
   - You can either clone the repository or simply use the installer provided at this link:  
     [Download Installer](https://drive.google.com/file/d/1mueNMNuqGqPMRUPdTh_k5yREYJqkhWWL/view?usp=sharing)

2. **Run the Application**:
   - If you chose to clone the repository, run the project from your development environment.
   - If you used the installer, simply run the installed application.

3. **Upload the Followers List**:
   - In the "People Who Follow You" section, click **Browse** and select `followers_1.json`.
    ![16.png](/src/16.png)
    ![17.png](/src/17.png)

4. **Upload the Following List**:
   - In the "People You Follow" section, click **Browse** and select `following.json`.
    ![18.png](/src/18.png)
    ![19.png](/src/19.png)


5. **Find Unfollowers**:
   - Once you have uploaded the corresponding JSON files to the correct sections, click **Find** in the "People Who Don't Follow You Back" section.
   - The results will be displayed in a Data Grid View.
    ![20.png](/src/20.png)

6. **Unfollow Users**:
   - To unfollow someone, double-click on their link in the Data Grid View. This will redirect you to their Instagram profile, where you can choose to unfollow them.
  

### Credits:
- [Instagram Logo](https://www.freepik.com/free-vector/instagram-icon_954290.htm#fromView=keyword&page=1&position=2&uuid=0c76f387-d988-4057-a522-a373ad13e108)
- [Blank Profile Picture](https://cdn.pixabay.com/photo/2015/10/05/22/37/blank-profile-picture-973460_960_720.png)
