# UiPath Custom Activity: PrtMessageActivity

A simple custom activity for UiPath Studio that takes a name input and returns a greeting message.

## Package Information

- **Package Name:** `PrtMessageActivity`
- **Latest Version:** `1.0.5`
- **Supported Runtimes:**
  - Windows-.NET6
  - Windows-.NETFramework (4.6.1+)

---

## Installation Instructions for UiPath Studio 24.10.x

### Step 1: Add Local Package Source

1. Open **UiPath Studio**
2. Click **Manage Packages**
3. Click the **Settings (⚙️)** icon
4. Click **Add Package Source**
5. Select **Local Feed**
6. Enter the path:
   ```
   /workspaces/UiPathCustomActivity/PrtMessageActivity/bin/package/
   ```
7. Click **Add** → **Save**

### Step 2: Update Your Project's project.json

**IMPORTANT:** Your UiPath project's `targetFramework` must specify a runtime version.

Currently, your `project.json` has:
```json
"targetFramework": "Windows"
```

**Change it to one of the following:**

**Option A: .NET 6 (Recommended for Studio 24.10.x)**
```json
"targetFramework": "Windows-.NET6"
```

**Option B: Legacy .NET Framework**
```json
"targetFramework": "Windows-.NETFramework"
```

**How to edit:**
1. Close your UiPath project
2. Open `project.json` in a text editor
3. Find line ~22: `"targetFramework": "Windows"`
4. Replace with your chosen option
5. Save the file
6. Reopen the project in UiPath Studio

### Step 3: Install the Package

1. Go to **Manage Packages** in UiPath Studio
2. In the **Available Packages** tab, search for `PrtMessageActivity`
3. Click **Install** (version 1.0.5 or latest)
4. Wait for completion
5. Close and reopen your project

### Step 4: Use the Activity

The activity should now appear in the **Activities** pane when you search for `PrtMessageActivity`.

---

## Activity Details

### Display Names
- `PrtMessageActivity`
- `PrtMessageBoxActivity`

### PrtMessageActivity
- **InputName** (String) — The name to include in the greeting
- **ResultMessage** (String) — The greeting message returned

### PrtMessageBoxActivity
- **InputName** (String) — The name to include in the greeting
- **Title** (String) — The message box title

### Example
```
Input: "John"
Output: "Hello, John"
```

### Message Box Example
```
Sequence
├─ Assign: name = "World"
├─ PrtMessageBoxActivity
│  ├─ InputName = name
│  └─ Title = "Welcome"
```

This activity shows a dialog with the greeting when executed.

---

## Example Workflow

```
Sequence
├─ Assign: name = "World"
├─ PrtMessageActivity
│  ├─ InputName = name
│  └─ ResultMessage = greeting
└─ Log Message: greeting
   Output: "Hello, World"
```

---

## Troubleshooting

### Activity not appearing in Activities pane

**Cause:** Your UiPath project's `targetFramework` is not set correctly.

**Fix:**
1. Edit `project.json`
2. Change `"targetFramework": "Windows"` to `"Windows-.NET6"` or `"Windows-.NETFramework"`
3. Restart UiPath Studio

### Package installation fails

**Cause:** Local package source path is incorrect.

**Fix:**
1. Verify the path includes `/bin/package/` folder
2. Ensure `PrtMessageActivity.1.0.3.nupkg` exists at that location
3. Refresh the package source

### Multiple package versions conflict

**Cause:** Old versions of the package remain installed.

**Fix:**
1. Go to **Manage Packages**
2. Remove older versions (keep only 1.0.3)
3. Reinstall the latest version
4. Restart Studio

---

## Building from Source

To rebuild the custom activity:

```bash
cd PrtMessageActivity
dotnet build -c Release
dotnet pack -c Release
```

Output package location:
```
PrtMessageActivity/bin/package/PrtMessageActivity.1.0.5.nupkg
```

---

## Your UiPath Project Configuration

Based on your `project.json`:

```json
{
  "studioVersion": "24.10.14.0",
  "targetFramework": "Windows",  ← CHANGE THIS
  "expressionLanguage": "VisualBasic"
}
```

**Required Change:**
```json
{
  "studioVersion": "24.10.14.0",
  "targetFramework": "Windows-.NET6",  ← Updated
  "expressionLanguage": "VisualBasic"
}
```

---

## Support

If the activity still does not appear:
1. Verify `targetFramework` in `project.json`
2. Check that the package is listed in Manage Packages
3. Restart UiPath Studio
4. Search for `PrtMessageActivity` in the Activities pane
