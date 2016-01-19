--ASPI-Team 04 // He thong theo doi suc khoe
create database HealthCareDB 
go
use HealthCareDB
go
create table BenhNhan
(
	TenDangNhap char(30),
	MatKhau char(30),
	TenBenhNhan nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3)check (GioiTinh in(N'Nam', N'Nữ')),
	Email char(30),
	DienThoai char(11),
	DiaChi nvarchar(50),
	NhanBaiDang int,
	primary key(TenDangNhap)
)

create table NguoiThan
(
	BenhNhan char(30),
	NguoiThan char(30),
	MucDo char(20),
	primary key(BenhNhan, NguoiThan)
)

create table BaiDang
(
	MaBaiDang int IDENTITY PRIMARY KEY,
	TieuDe nvarchar(100),
	NoiDung nvarchar(1000)
)

create table BacSi
(	
	MaBacSi int IDENTITY PRIMARY KEY,
	TenBacSi nvarchar(50),
	NgaySinh date,
	GioiTinh nvarchar(3)check (GioiTinh in(N'Nam', N'Nữ')),
	Email char(30),
	DienThoai char(11),
	DiaChi nvarchar(50),
	ChuyenNganh nvarchar(50),
	BangCap nvarchar(30)
)

create table DuLieuKham
(
	MaDuLieuKham int IDENTITY PRIMARY KEY,
	NhipTim int,
	CamXuc nvarchar(15),
	ChieuCao int,
	CanNang int,
	NgayKham date,
	BenhChanDoan int,
)

create table ChiTietKham
(
	BenhNhan char(30),
	DuLieuKham int,
	primary key(BenhNhan, DuLieuKham)
)

create table TrieuChungKham
(
	DuLieuKham int,
	TrieuChung int,
	primary key(DuLieuKham, TrieuChung)
)

create table ViTriBenh
(
	MaViTri int IDENTITY PRIMARY KEY,
	TenViTri nvarchar(50),
)

create table TrieuChung
(
	MaTrieuChung int IDENTITY PRIMARY KEY,
	TenTrieuChung nvarchar(50),
)

create table TrieuChung_ViTri
(
	MaViTri int,
	MaTrieuChung int,
	primary key(MaViTri, MaTrieuChung)
)

create table Benh
(
	MaBenh int IDENTITY PRIMARY KEY,
	TenBenh nvarchar(50),
	NoiDung char(2000),
	LoiKhuyen char(2000),
)

CREATE TABLE TrieuChung_Benh
(
	MaTrieuChung INT,
	MaBenh INT,
	PRIMARY KEY(MaBenh, MaTrieuChung)
)

CREATE TABLE KhamDinhKy
(
	MaKham int IDENTITY PRIMARY KEY,
	MaBenhNhan CHAR(30),
	NhipTim INT,
	CamXuc NVARCHAR(15),
	NgayKham DATE
)


go
ALTER TABLE TrieuChung_ViTri
ADD CONSTRAINT FK_TCVT_ViTri
FOREIGN KEY (MaViTri)
REFERENCES ViTriBenh(MaViTri) 

go
ALTER TABLE TrieuChung_ViTri
ADD CONSTRAINT FK_TCVT_TrieuChung
FOREIGN KEY (MaTrieuChung)
REFERENCES TrieuChung(MaTrieuChung) 

go
ALTER TABLE ChiTietKham
ADD CONSTRAINT FK_ChiTietKham_DuLieuKham
FOREIGN KEY (DuLieuKham)
REFERENCES DuLieuKham(MaDuLieuKham) 

go
ALTER TABLE ChiTietKham
ADD CONSTRAINT FK_ChiTietKham_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(TenDangNhap) 
 
go
ALTER TABLE TrieuChungKham
ADD CONSTRAINT FK_TrieuChungKham_DuLieuKham
FOREIGN KEY (DuLieuKham)
REFERENCES DuLieuKham(MaDuLieuKham) 

go
ALTER TABLE TrieuChungKham
ADD CONSTRAINT FK_TrieuChungKham_TrieuChung
FOREIGN KEY (TrieuChung)
REFERENCES TrieuChung(MaTrieuChung)

go
ALTER TABLE DuLieuKham
ADD CONSTRAINT FK_DuLieuKham_Benh
FOREIGN KEY (BenhChanDoan)
REFERENCES Benh(MaBenh)

go 
ALTER TABLE NguoiThan
ADD CONSTRAINT FK_NguoiThan_BenhNhan
FOREIGN KEY (BenhNhan)
REFERENCES BenhNhan(TenDangNhap)

go 
ALTER TABLE NguoiThan
ADD CONSTRAINT FK_NguoiThan_NguoiThan
FOREIGN KEY (NguoiThan)
REFERENCES BenhNhan(TenDangNhap)

go 
ALTER TABLE dbo.TrieuChung_Benh
ADD CONSTRAINT FK_TrieuChungBenh_Benh
FOREIGN KEY (MaBenh)
REFERENCES Benh(MaBenh)

go 
ALTER TABLE dbo.TrieuChung_Benh
ADD CONSTRAINT FK_TrieuChungBenh_TrieuChung
FOREIGN KEY (MaTrieuChung)
REFERENCES dbo.TrieuChung(MaTrieuChung)

go
ALTER TABLE KhamDinhKy
ADD CONSTRAINT FK_KhamDinhKy_BenhNhan
FOREIGN KEY (MaBenhNhan)
REFERENCES BenhNhan(TenDangNhap)


go
insert into BenhNhan 
VALUES  ('admin', 'admin', N'admin', '1995-01-01', N'Nam', 'admin@gmail.com', '0123456789',N'123', 0), 
		('bn1', 'bn1', N'Bùi Trung Hải', '1995-01-01', N'Nam', 'btHai@gmail.com', '0123456789',N'123', 0), 
		('bn2', 'bn2', N'Nguyễn Nhật Tài', '1995-03-01', N'Nam', 'nnTai@gmail.com', '0123456789',N'123', 0),  
		('bn3', 'bn3', N'Nguyễn Phan Mạnh Hùng', '1995-05-01', N'Nam', 'npmHung@gmail.com', '0123456789',N'123', 0), 
		('bn4', 'bn4', N'Lê Huy Sinh', '1995-07-01', N'Nam', 'lhSinh@gmail.com', '0123456789',N'123', 0)

go 
insert into NguoiThan
values('bn1', 'bn2', 'Than'),
		('bn1', 'bn3', 'Than'),
		('bn1', 'bn4', 'Than'),
		('bn2', 'bn1', 'Than'),
		('bn3', 'bn4', 'Than'),
		('bn4', 'bn1', 'Than')

go
insert into Benh values ('Trauma', 'Trauma most often refers to serious bodily injury or wounds. Accidents, falls, blows, burns, or weapons can cause physical trauma. But trauma can also be emotional or psychological injury from an extremely distressing or shocking event, such as an accident, rape, the breakup of a relationship, or a loved one is sudden death. It can occur without physical injury. Acute trauma symptoms are those that happen immediately after injury – such as bruises or bleeding, or shock and denial.Chronic trauma symptoms can occur long after an injury appears to have healed. They can be physical – like pain, headaches, or fatigue – or emotional – like anger, anxiety, and difficulty concentrating. Trauma usually requires medical or psychological treatment.'
, 'Treatment for physical trauma depends on the nature and severity of the injury.Surgery, medical procedures, medication, and physical or occupational therapy are common treatments. Emotional or psychological trauma may be treated with medication, talk therapy, cognitive behavioral therapy, or other types of psychological therapy.'),
						('Broken ribs', 'Broken ribs are a common injury. A blow to the chest - during a car accident, a fall, or a football game -- may break a rib. Older people, especially women, have a higher risk of broken ribs because their bones tend to be weaker. Repetitive stress to the bones - from a severe chronic cough, for instance -- can also break a rib. Broken ribs can cause mild or severe pain. Typically, ribs heal on their own in one or two months. In the meantime, rest and pain relievers can help ease the pain'
, 'Treatments for rib fracture may include: 
• Rest 
• Over-the-counter or prescription medicines to reduce pain and swelling 
• Icing the area for 10 minutes at a time 
• Nerve blocks -- special injections of anesthesia 
• Surgery and hospitalization (for severe cases or complications)
-You should get plenty of rest to let your rib heal. Icing the area and using NSAIDs - such as ibuprofen or naproxen -will ease pain and swelling. Painkilling creams -- with capsaicin or arnica -- may help, too. Try to take a deep breath once an hour, even if it hurts. It will help prevent pneumonia and keep the lungs healthy'),
						('Bruise or contusion', 'Bruises, or contusions, occur when an area of the body is hit or injured and small blood vessels are broken. The damaged small blood vessels leak under the skin, causing a tender, reddish purple area. This is a bruise'
, 'Bruises usually do not require treatment.
- Apply an ice pack 20 to 30 minutes at a time in the first 24 to 48 hours. If you do not have an ice pack, use a bag of frozen peas or corn, wrapped in a towel. 
• Keep the area elevated if possible. 
• Take OTC pain medications (avoid aspirin and NSAIDs) if needed for pain. 
• Apply a warm wash cloth to the area after 48 hours to help speed healing'),
						('Hematoma', 'A hematoma is a collection of blood that pools in tissue outside of a damaged blood vessel, usually after an injury. Hematomas look like a deep bruise and range in size from very small to as large as a grapefruit. Taking blood thinners--even aspirin--can increase the risk for hematomas. Most hematomas under the skin and fingernails go away on their own. However, subdural hematomas that form between the brain and skull are very dangerous and even fatal if not treated quickly','For hematomas of the skin and muscles, treatment includes: 
• Resting the injury 
• Icing the area 
• Elevation and/or compression with an elastic bandage 
• Taking over-the-counter pain medication 
 A large internal hematoma, which may become infected, should be treated by a doctor. Depending on the size and location, your doctor may drain the blood from it.For a subdural hematoma, doctors may perform emergency surgery to relieve the pressure on the brain.
- Most small hematomas clear up on their own. However, you can drain a hematoma under a fingernail or toenail to relieve pain and pressure. Heat the end of a paper clip until it is red-hot and push it through the nail to allow blood to escape. If you are not comfortable doing this, your doctor can drain the hematoma. Otherwise, just watch and wait as the body naturally reabsorbs the blood over time.'),
						('Muscle strain', 'Muscle strain occurs when muscles are stressed, overworked, or injured due to exercise, sports, or hard physical labor. Strenuous activity can cause small tears in muscle and tendon fibers. These tears lead to inflammation and soreness',
'The following treatments help relieve muscle strain: 
• Rest for a day or two; then do gentle stretching. 
• Ice the area for 20 minutes each waking hour for 1 to 3 days. 
• Wrap the injury in an elastic bandage to reduce swelling. 
• Elevate the area to help relieve swelling
• Use heat on the muscle after 72 hours. 
• Take anti-inflammatory medications (NSAIDs) to relieve pain and swelling. 
- Most strains can be self-treated at home using rest, ice, elevation, and NSAIDs.'),
						('Common Cold','The common cold is a short-lived viral infection of the upper respiratory tract, which includes the nose and sinuses, mouth, and throat. Symptoms may include sore throat, stuffy or runny nose, nasal drip, headache, and slight muscle aches. Because more than 200 viruses cause colds, and new ones develop all the time, the body can not build immunity to colds. Colds spread easily from person to person and are the most common illness in the world. Most colds go away within a few days and do not cause serious health problems',
'Medications to relieve fever and pain, such as acetaminophen (Tylenol) and ibuprofen (Advil, Motrin) 
• Antihistamines and decongestants to open nasal passages 
• Gargling with warm salt water
• Drinking warm liquids to soothe the throat
• Sucking on hard candies or throat lozenges
• Rest
• Not smoking
• Zinc tablets; recent studies suggest zinc reduces the length of time and severity of cold symptoms
• Chicken soup really has been shown to help some, too'),	
						('Bronchitis','- Bronchitis is an inflammation of the bronchial tubes, the large airways leading from the throat into the lungs. This common condition causes a cough that produces mucus. Bronchitis usually comes and goes within a few days. Cold viruses are the most common cause of bronchitis, but it can also be caused by bacteria. Some people, usually smokers, develop chronic bronchitis, which never goes away completely','- For a simple case of bronchitis, treatment may include: 
• Rest 
• Drinking plenty of fluids 
• Breathing in warm, moist air 
• Over-the-counter pain relievers and fever reducers
• Medications to help reduce coughing and open your airways 
Antibiotics do not help if the bronchitis is viral, such as when it is due to a cold. But if the mucous is thick and yellow, or if the symptoms are severe or persistent, your doctor may feel they are necessary. \n- You can usually treat viral bronchitis at home by just waiting it out and using home remedies, OTC pain relievers, and cough suppressants. If you smoke, stop. If symptoms lasts more than a few days, are severe or if you start wheezing, you should see your doctor.'),	
						('Heart rhythm disorder','- Heart rhythm disorder – heart arrhythmia - happens when the electrical impulses that control your heartbeat do not work correctly. Your heart may beat too slowly, too quickly, or have an irregular beat. Many heart rhythm problems are harmless. But some long-lasting heart rhythm disorders can cause a fluttering in the chest, shortness of breath, chest pain, or dizziness. Atrial fibrillation, when the upper chambers of the heart beat fast and out of rhythm, is a common heart rhythm disorder. It can be dangerous over time. Another type of problem, ventricular fibrillation, can cause death within minutes. It causes the lower chambers of the heart to quiver, so the heart can not pump any blood. Ventricular fibrillation is an emergency and needs to be treated with an electrical shock (defibrillator) to keep the heart working.'
,'- Treatment for heart rhythm disorders varies depending on the type of disorder you have. Some of these treatments include: 
• Medications to stop the arrhythmia 
• A pacemaker or implanted cardiac defibrillator (ICD) 
• Cardioversion, a shock to reset your heart 
• Ablation therapy, which destroys tissue to stop the abnormal heartbeat 
• Surgery
- Having heart disease puts you at risk for heart rhythm disorders. Keeping your heart healthy may be helpful in preventing some heart rhythm disorders. Here is what you can do: 
• Stop smoking. 
• Eat a heart-healthy diet. 
• Get regular exercise. 
• Limit alcohol and caffeine. 
• Control stress. 
• Do not take medications that contain stimulants, such as some over-the-counter drugs for colds.'),
						('Medication Reaction or Side Effect','All medications and even natural remedies have side effects in the right circumstances. An allergy, sensitivity to medication, or a reaction to a large dose of medicine can all cause side effects.','- Stopping the medication immediately and treating any symptoms as necessary
- Most medication reactions improve hours after stopping the medication. An allergic reaction can be serious and should be treated by a doctor as soon as possible'),
						('Generalized Anxiety Disorder', 'Everyone feels anxious sometimes, but generalized anxiety disorder is a condition in which a person has nearly constant anxiety. People with generalized anxiety disorder often feel anxious for no apparent reason. They also may feel tired, restless, irritable, short of breath, have difficulty concentrating or sleeping, or have a racing heartbeat. Doctors aren not sure what causes generalized anxiety disorder, but it can run in families. Stressful life situations also may cause the disorder. It can start anytime in life, even in childhood. Medications and psychotherapy, along with lifestyle changes, can help'
, '- Treatment for generalized anxiety disorder usually includes: 
• Cognitive-behavioral therapy 
• Medications, including antidepressants and anti-anxiety medications 
• Support groups                                                               
- You may be able to ease the symptoms of generalized anxiety disorder by: 
• Learning relaxation techniques 
• Getting exercise every day 
• Eating a healthy diet 
• Getting enough sleep 
• Avoiding alcohol, caffeine, and illegal drugs'), 
						('Depression', '- Depression is a painful sadness or down mood that interferes with daily life. Many people feel down for short periods, but depression lasts a long time and may include anxiety, insomnia, and other symptoms. Life events such as the death of a loved one can trigger depression. The illness can run in families, but people with no family history also become depressed. Often there is no clear cause. Depression is a common but serious illness that usually does not go away without treatment. Counseling and/or antidepressant medication can treat depression in most people.'
,'- Depression treatment may include: 
• Antidepressant medication 
• Counseling 
• Electroconvulsive therapy for severe depression and if antidepressants do not work
- Getting treatment for depression can help you feel better faster. But you can also do things on your own to feel better. Eating a healthy diet, getting regular exercise, reducing stress, talking with friends, and being patient with your progress can help you cope with depression.'),
						('Excessive caffeine use','Excessive caffeine use, typically more than three cups of coffee a day, can drain energy and cause frayed nerves. It also can make your heart beat faster, cause an uneven heart rhythm, raise your blood pressure, worsen anxiety and panic, and cause dehydration. Sensitivity to caffeine varies among people, and some people can consume more without ill effect. But often people do not know how much caffeine they have consumed, because the drug is not only in coffee but in tea, soft drinks, energy drinks, chocolate, and some medications.'
,'- Treatment for caffeine overuse involves gradually cutting back, then using caffeine in moderation or avoiding caffeine altogether.
- If you stop caffeine completely you may have withdrawal symptoms for 72 hours or longer. Those symptoms might include sleepiness, headache, and fatigue. Gradually tapering off on how much coffee you drink can help your body get used to lower levels of caffeine without withdrawal symptoms. Also, taking small amounts of chocolate or tea can help relieve headaches and other withdrawal symptoms until your body gets used to less or no caffeine.'),
						('Short-acting sedative use', '- Short-acting sedatives are a common type of medication used to treat a wide variety of conditions, from insomnia and anxiety to amnesia. They are a type of depressant and are sold under many names, including Ativan, Klonopin, Valium, and Xanax. While these drugs can help ease the symptoms of many conditions, they can also cause side effects. Short-acting sedatives can cause drowsiness, vertigo, poor concentration, double vision, muscle weakness, slurred speech, memory problems, irritability, and depression. The symptoms can vary widely from person to person. In most cases, the higher your dose, the more likely you are to have symptoms. People who take short-acting sedatives over a long time may also develop an addiction to these drugs.'
, '- Treatment usually involves lowering your dose or taking another type of medication'),
						('Tension headaches','Tension headaches are the most common type of headache, caused by muscle tension in the neck, face, jaw, or shoulders. Many people have occasional tension headaches, which often start in the middle of the day. For others, tension headaches occur every day. Everyday stress, lack of sleep, anxiety, depression, bad posture, hunger, and tiredness can all trigger a tension headache'
,'- Treatment for tension headaches includes: 
• Pain relievers 
• Muscle relaxants 
• Medication to help prevent headaches
- You can treat tension headaches at home by taking over-the-counter pain relievers, taking a hot or cold shower, and relaxing'),
						('Acute sinusitis', 'Acute sinusitis is an inflammation of the sinuses caused by infection lasting less than 4 weeks. Sinusitis often develops when swelling, inflammation, and mucus from a cold block nasal passages. This makes it easier for bacteria to grow. Organisms can produce gas, and when your sinuses are not draining, pressure can quickly build and cause the infection to spread. Viruses are the most common cause of acute sinusitis, but bacteria, fungi, and allergies may also cause it. Sinus pain and tenderness are common, but severe pain may indicate an abscess or other complication'
, '- Treatments for acute sinusitis may include: 
• Flushing nasal passages with warm salt water (Neti pot) or saline nasal spray
• Warm packs 
• Antibiotics for bacterial infections 
• Cortisone and other nasal sprays for inflammation and allergy control 
• Sinus drainage procedures 
• Oral antihistamines and/or decongestants
- At the first sign of sinus pain, you may be able to head off an infection by irrigating your sinuses at home using a nasal syringe or neti pot filled with sterile warm salt water. Avoid overusing antihistamines; they may dry your sinuses and cause irritation. You can use non-prescription decongestant sprays if your doctor says it is OK, but not for more than 1 to 3 days as they may cause rebound congestion. Natural remedies that may help some people include bromelain and steam inhalation. If you have bloody, discolored sinus drainage or severe pain, see your doctor as soon as possible.'),
						('Acute stress reaction', 'Acute stress reaction, or acute stress disorder, is a physical and psychological reaction to a stressful situation. It can cause shortness of breath, rapid heartbeat, increased blood pressure, anxiety, and a sense of impending doom. These reactions can be normal after an unusually severe and stressful event such as the death of a loved one, a natural disaster, or physical violence.', 
'- Treatment for an acute stress reaction may include: 
• Anti-anxiety medication 
• Antidepressants 
• Cognitive Behavioral Therapy'),
						('Asthma', '- Asthma is a lung condition that causes airways to swell and become inflamed. Asthma makes it hard to breathe. Some people may have minor symptoms, but others may have severe symptoms that interfere with daily life. Having severe asthma may put you at risk for a life-threatening asthma attack. Symptoms of an asthma attack include wheezing, chest tightness, coughing, and shortness of breath. Doctors do not know exactly what causes asthma, but genetic and environmental factors may play a role. Triggers such as smoking, air pollution, allergies, exercise, stress, GERD, and colds can bring on asthma attacks. Asthma is a lifelong condition that can be managed but not cured. Avoiding asthma triggers and taking medication help most people avoid attacks and keep symptoms under control.'
,'- Treatment for asthma includes an asthma action plan that has in writing when to take certain medications based on your symptoms. Medications include both those for long-term control and for quick relief: 
• Long-term control medications include inhaled corticosteroids, leukotriene modifiers, long-acting beta agonists, combination inhalers, omalizumab (Xolair). 
• Quick-relief or rescue medications include short-acting bronchodilators and oral corticosteroids. 
• Allergy treatment, if your asthma is triggered by allergies
- Learning to identify and avoid triggers can help prevent asthma attacks. Most people manage their asthma at home with the help of an asthma action plan that explains what type and how much asthma medication to use. It also includes when to call the doctor or go to an emergency room. Specific steps that may help include: 
• Running your air conditioner 
• Avoiding pet dander 
• Wearing a mask when cleaning (or having someone clean house for you) 
• Encasing pillows, mattresses, and box springs in dust-proof covers 
• Choosing hardwood floors instead of carpeting and blinds instead of drapes 
• Getting regular exercise (wearing a face mask when it is cold) 
• Staying at a healthy weight 
• Eating a healthy diet with lots of fruits and vegetables'),
						('Anemia of Chronic Disease','- Anemia occurs when a person has too few red blood cells. These cells carry oxygen and other nutrients throughout the body. Signs of anemia can include weakness, tiredness, difficulty breathing, dizziness, and other symptoms. Anemia of chronic disease (ACD) is caused by certain inflammatory or infectious diseases, such as autoimmune disorders, cancer, kidney disease, cirrhosis, and long-term infections such as HIV and hepatitis B. ACD is likely a protective reaction the body has to the underlying disease. All living cells, including bacteria and even cancer cells, need iron. ACD limits the amount of iron that is available for whatever agent is causing the disease. Treatment for ACD consists of treating the underlying condition that is causing it.'
,'- Anemia of chronic disease is usually mild and the disease generally requires no treatment. When the underlying condition that is causing it is treated, ACD usually improves or goes away on its own. A very severe case may require a blood transfusion, but that is rare. Iron supplements and vitamins, which may be used to treat other types of anemia, are not effective. In fact, taking iron supplements could cause life-threatening complications.
- For ACD it is important to follow the treatment plan for the condition that is causing it. Trying to treat the anemia on your own with iron supplements could be dangerous. Do not take any over-the-counter supplements without discussing it with your doctor first.'),
						('Vasovagal syncope','- Vasovagal syncope is the most common reason that people faint. It happens when your body overreacts to emotional or physical stress such as seeing something unpleasant or standing for too long. This reaction causes your blood pressure to drop and less blood to flow to your brain, which makes you faint. Vomiting, coughing, defecating and urinating are also forms of vasovagal syncope.'
,'- Vasovagal syncope usually does not need any treatment. But if you faint often, your doctor may recommend one of the following treatments: 
• Medications 
• Leg exercises or special elastic stockings 
• A pacemaker
- To ease the symptoms of vasovagal syncope, try these self-care tips:
• Lie down and raise your legs 
• Sit down and put your head between your knees 
• Loosen any tight clothing or belts'),
						('Heat exhaustion', 'Heat exhaustion develops when your body can not keep itself cool. You may get it after a tough workout in the sun. Or you may develop it gradually over days if it is hot and you are not drinking enough fluids. Young children, older adults, and people with health conditions such as high blood pressure or heart disease have a higher risk. Cooling down is the treatment. Act quickly. If you do not treat heat exhaustion, you could develop heatstroke, which is more severe and sometimes deadly.'
,'-Cooling down is the key. Treatments include: 
• Getting out of the sun and heat 
• Sipping cool drinks, but not drinks with caffeine or alcohol 
• Rest 
• Cooling down in an air-conditioned room
• A cold shower or bath 
• Icing your neck and back 
• IV fluids
- As long as you are generally healthy and do not have signs of heat stroke you can treat mild heat exhaustion at home. Get out of the heat and sun. Rest and have a cool drink. Put on cool, light clothes. 
• Avoid caffeinated drinks and alcohol. 
• Use an air conditioner or take a cold shower. 
• Drink water or a sports drink with electrolytes. Ice your neck or lower back. 
• Stay out of the heat for a few days. 
If your symptoms do not get better within half an hour or you have nausea or vomiting, call the doctor.'),
						('Low blood pressure', 'Low blood pressure, or hypotension, can make you feel lightheaded and dizzy. Blood pressure is the force of your blood as it pushes against the walls of your arteries. If it is too low, your body may not get enough blood. Many people have occasional moments of low blood pressure after standing up suddenly or a tough workout. Dehydration, drug side effects, heart problems and other medical conditions can cause it. Low blood pressure can be dangerous if it makes you so dizzy that you fall, especially if you are older. If you need them, treatments will help.'
, '- Treatment depends on the cause of your low blood pressure. Treatments include: 
• Switching medications if a drug is causing your symptoms 
• Drinking more fluids if you are dehydrated 
• IV fluids 
• Compression stockings 
• Increasing salt in your diet -- but only if your doctor suggests it 
• Medicines to increase blood pressure 
• Managing underlying causes, such as thyroid or heart problems 
Many cases of low blood pressure do not need -treatment.
–If you feel faint or lightheaded, sit or lie down. Raise your feet over your heart. Ask someone to get you a drink, such as a sports drink with minerals. After you feel better, see the doctor. If you suspect a prescription drug is causing your symptoms, do not stop taking it unless your doctor agrees. Avoid triggers, such as alcohol, dehydration, standing for a long time, or getting up suddenly.')	
go

insert into TrieuChung values	(N'Bleeding'),
								(N'Broken bone'),
								(N'Bruising or discoloration'),
								(N'Cough'),
								(N'Slow heart rate (pulse)'),
								(N'Anxiety'),
								(N'Blackouts (memory time loss)'),
								(N'Headache'),
								(N'Difficulty sleeping'),
								(N'Fainting')
go
insert into ViTriBenh values ('Chest'),
('Head') 

go
insert into TrieuChung_ViTri values (1,1),
(1,2),
(1,3),
(1,4),
(1,5),
(2,6),
(2,7),
(2,8),
(2,9),
(2,10)

GO
INSERT INTO dbo.TrieuChung_Benh
        ( MaTrieuChung, MaBenh )
VALUES  (1,  1),
		(2, 2),
		(2, 1),
		(3, 3),
		(3, 4),
		(3, 5),
		(4, 6),
		(4, 7),
		(5, 8),
		(5, 9),
		(6, 10),
		(6, 11),
		(6, 12),
		(7, 9),
		(7, 13),
		(8, 14),
		(8, 15),
		(8, 16),
		(9, 11),
		(9, 12),
		(9, 17),
		(9, 18),
		(10, 19),
		(10, 8),
		(10, 9),
		(10, 20),
		(10, 21)
go
insert into BacSi 
values(N'Bùi Trung Hải', '1995-01-01', N'Nam', 'btHai@gmail.com', '0123456789',N'123', N'Rang Ham Mat', N'Tien sĩ'), 
		(N'Nguyễn Nhật Tài', '1995-03-01', N'Nam', 'nnTai@gmail.com', '0123456789',N'123', N'Da liễu', N'Thạc Sĩ'),  
		(N'Nguyễn Phan Mạnh Hùng', '1995-05-01', N'Nam', 'npmHung@gmail.com', '0123456789',N'123', N'Nội khoa', N'Thạc sĩ'), 
		(N'Lê Huy Sinh', '1995-07-01', N'Nam', 'lhSinh@gmail.com', '0123456789',N'123', N'Tim mạch', N'Tiến sĩ')

go 
insert into DuLieuKham
values(80, N'Vui', 170, 60, '2015-12-20', 1),
		(90, N'Chán', 170, 60, '2015-12-20', 2),
		(75, N'', 170, 60, '2015-12-20', 3),
		(79, N'Vui', 170, 60, '2015-12-20', 4),
		(85, N'Vui', 170, 60, '2015-12-20', 5),
		(100, N'Buồn', 170, 60, '2015-12-20', 6),
		(70, N'Vui', 170, 60, '2015-12-20', 7),
		(80, N'Vui', 170, 60, '2015-12-20', 8),
		(85, N'Vui', 170, 60, '2015-12-20', 9),
		(89, N'Ngạc nhiên', 170, 60, '2015-12-20', 10),
		(95, N'Vui', 170, 60, '2015-12-20', 11),
		(87, N'Vui', 170, 60, '2015-12-20', 12),
		(88, N'Vui', 170, 60, '2015-12-20', 13),
		(67, N'Vui', 170, 60, '2015-12-20', 14),
		(76, N'Buồn', 170, 60, '2015-12-20', 15),
		(89, N'Vui', 170, 60, '2015-12-20', 16),
		(98, N'Vui', 170, 60, '2015-12-20', 17)

go
insert into ChiTietKham
values ('bn1', 1),
		('bn1', 2),
		('bn1', 3),
		('bn1', 4),
		('bn1', 5),
		('bn1', 6),
		('bn1', 7),
		('bn1', 8),
		('bn1', 9),
		('bn1', 10),
		('bn1', 11),
		('bn1', 12),
		('bn1', 13),
		('bn1', 14),
		('bn1', 15),
		('bn1', 16),
		('bn1', 17)

go
insert into BaiDang
values (N'CÁC BỆNH THƯỜNG GẶP TRONG MÙA MƯA VÀ CÁCH PHÒNG TRÁNH HIỆU QUẢ', N'Mùa mưa có thể mang lại niềm vui và hứng thú cho nhiều bạn bởi tiết trời mát mẻ và thoáng đãng. Nhưng cũng mang đến nhiều nguy cơ rối loạn sức khỏe. Hạn chế rủi ro mắc phải những căn bệnh thông thường trong mùa mưa hoàn toàn không khó. Bệnh thường thấy nhất là liên quan đến hệ hô hấp và tiêu hóa. Nên cẩn trọng với triệu chứng của những căn bệnh này để có thể phòng tránh và chữa trị kịp thời.
Cảm và cúm là hai bệnh mà rất nhiều người mắc phải khi mùa mưa đến. Nguyên nhân là do sự thay đổi nhiệt độ và độ ẩm. Bạn không nên dầm mưa và không được để cơ thể bị ướt quá lâu trong nước mưa. 
Một số bệnh khác cũng cần phải lưu ý: sốt phát ban, nhiễm trùng máu, nhiễm trùng nước, bệnh tả, bệnh trùng xoắn móc câu (khuẩn xoắn móc câu kí sinh có thể gây nguy hại cho thận, gan, gây viêm màng não và hô hấp cấp)…'),
		(N'Bệnh về tim mạch', N' Trong số các bệnh về tim mạch ở NCT thì bệnh xơ vữa động mạch, thiểu năng mạch vành, tăng huyết áp chiếm một vị trí đáng kể. Trong một số trường hợp, các loại bệnh này thường thấy ở những người nghiện bia, rượu chiếm tỷ lệ cao hơn những người không nghiện bia, rượu'),
		(N'Bệnh về hệ hô hấp', N'Bệnh viêm họng, viêm phế quản mạn tính, giãn phế quản, âm phế mạn tính, hen phế quản, bệnh phổi tắc nghẽn mạn tính là những bệnh gặp khá nhiều ở NCT, nhất là ở những người có tiền sử hoặc đang hút thuốc lá, thuốc lào. Đặc điểm bệnh về đường hô hấp lại thường hay xảy ra vào mùa lạnh, thay đổi thời tiết, lúc giữa đêm gần sáng do đó rất dễ làm cho NCT mất ngủ kéo dài'),
		(N'Bệnh về đường tiêu hóa', N'người cao tuổi rất dễ mắc bệnh rối loạn tiêu hóa như viêm loét miệng, ăn không tiêu, đầy hơi, trướng bụng, táo bón hoặc đi lỏng. NCT cũng có thể mắc bệnh viêm loét dạ dày - tá tràng, trào ngược thực quản hoặc viêm đại tràng mạn tính. Các loại bệnh dạng này thường làm cho người cao tuổi rất khó chịu, gây lo lắng, ăn không ngon, ngủ không ngon giấc hoặc kém ngủ, mất ngủ kéo dài. Mất ngủ lại làm cho nhiều bệnh tật phát sinh.'),
		(N'Bệnh về hệ tiết niệu - sinh dục', N'NCT cũng rất dễ mắc các bệnh về hệ tiết niệu - sinh dục, đặc biệt là u xơ tiền liệt tuyến hoặc ung thư tiền liệt tuyến. Những bệnh về sinh dục - tiết niệu thường có hiện tượng đi tiểu nhiều lần, đái dắt, đái són nhất là vào ban đêm, gây nhiều phiền toái cho NCT.')
go
create procedure sp_form_ThemBenhNhan @tenDN char(30), @mk char(30), @ten nvarchar(50), @ns datetime, @gt nvarchar(3), @email char(30), @dt char(11), @diaChi nvarchar(50) 
as
	insert into BenhNhan
	values (@tenDN, @mk, @ten, @ns, @gt, @email, @dt, @diaChi, null)


go
create procedure sp_form_TimNguoiThan @name nvarchar(50), @tenDN char(30)
as
	Select BN.TenBenhNhan
	From BenhNhan BN
	Where BN.TenBenhNhan like '%'+@name+'%' and BN.TenDangNhap != @tenDN and BN.TenDangNhap not in (Select NT.NguoiThan
																From NguoiThan NT
																Where NT.BenhNhan = BN.TenDangNhap)

go
create procedure sp_form_ThemNguoiThan @benhNhan char(30), @nguoiThan char(30)
as
	insert into NguoiThan
	values (@benhNhan, @nguoiThan, 'Than')

GO 
CREATE PROCEDURE sp_form_ThemDuLieuKham @ntim int, @cxuc nvarchar(15), @ccao INT, @cnang INT, @mabenh INT, @ma int OUT
AS
	BEGIN
		INSERT dbo.DuLieuKham
		        ( NhipTim ,CamXuc ,ChieuCao ,CanNang ,NgayKham ,BenhchanDoan)
		VALUES  ( @ntim , -- NhipTim - int
		          @cxuc , -- CamXuc - int
		          @ccao, -- ChieuCao - int
		          @cnang , -- CanNang - int
		          GETDATE(), -- NgayKham - datetime
		          @mabenh  -- BenhchanDoan - int
		        )
		SET @ma = @@IDENTITY
	END

GO
CREATE PROCEDURE sp_form_ThemBacSi @ten nvarchar(50), @ns DATE, @gt NVARCHAR(3), @email CHAR(30), @dt CHAR(11), @dc NVARCHAR(50), @cn NVARCHAR(50), @bc NVARCHAR(30)
AS
	BEGIN 
		INSERT INTO BacSi
		VALUES(@ten, @ns, @gt, @email, @dt, @dc, @cn, @bc)
	END  

GO
CREATE PROCEDURE sp_form_ThemBenh @ten NVARCHAR(50), @nd NVARCHAR(2000), @lk NVARCHAR(2000)
AS 
	BEGIN 
		INSERT INTO Benh
		VALUES(@ten, @nd, @lk)
	END 

GO
CREATE PROCEDURE sp_form_ThemTrieuChung @tenTC NVARCHAR(50), @maViTriBenh INT
AS
	BEGIN
		DECLARE @maTC INT
		INSERT into TrieuChung
		VALUES(@tenTC)

		SET @maTC = @@IDENTITY

		INSERT INTO dbo.TrieuChung_ViTri
		        ( MaViTri, MaTrieuChung )
		VALUES  ( @maViTriBenh, @maTC)
	END
    


	

    




