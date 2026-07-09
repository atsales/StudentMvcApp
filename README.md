# StudentMvcApp

## Overview
A learning project built with **ASP.NET Core MVC 8.0.22** and **Entity Framework Core**.  
This app demonstrates full CRUD operations connected to SQL Server.

---

## Progress Log

### ✅ Day 1–2: Setup
- Created HelloMvcApp and StudentMvcApp projects.
- Configured EF Core and SQL Server connection.
- Built initial MVC structure.

### ✅ Day 3–4: EF Core + CRUD
- Connected `CapstoneDB` to EF Core.
- Created `Student` model manually.
- Generated controller + views.
- Implemented full CRUD (Index, Create, Edit, Details, Delete).

### ✅ Day 5–6: SQL Practice
- Ran `SELECT`, `INSERT`, `UPDATE`, `DELETE` queries in SSMS.
- Verified EF Core changes directly in SQL Server.

### ✅ Day 7: Documentation + Review
- Updated README with screenshots.
- Reflected on schema design basics.

---

## Screenshots
- Index page (list of students)
<img width="1913" height="398" alt="image" src="https://github.com/user-attachments/assets/9964f97a-0363-43bb-a048-ff41254ed6c5" />

- Create form (adding a student)
<img width="1906" height="476" alt="image" src="https://github.com/user-attachments/assets/46b3b610-6f14-4072-8059-84a6af03f515" />
  
- Edit form (updating student info)
<img width="1909" height="419" alt="image" src="https://github.com/user-attachments/assets/ffba8bd9-2fd6-4201-a0d6-97a7e614c1ac" />
  
- Details page (viewing student record)
<img width="1912" height="355" alt="image" src="https://github.com/user-attachments/assets/89d51ad5-bed9-476f-a57d-f52d39264016" />

---

## Lessons Learned
- MVC folder structure and routing basics.
- EF Core DbContext setup and scaffolding.
- CRUD operations both in code and SQL.
- Schema design considerations (unique constraints, nullability, data validation).

---

## Next Steps
- Explore schema constraints (unique Email, non‑null EnrollmentDate).
- Prepare for Month 2: joins, relationships, and advanced queries.
