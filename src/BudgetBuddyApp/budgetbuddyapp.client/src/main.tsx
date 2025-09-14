import { StrictMode } from 'react'
import { createRoot } from 'react-dom/client'
import './index.css'
import App from './App.tsx'
import { MantineProvider } from '@mantine/core'
import { BrowserRouter, Route, Routes } from 'react-router-dom';
import ViewUsersPage from './Pages/ViewUsersPage/ViewUsersPage.tsx'
import UserDashboardPage from './Pages/UserDashboardPage/UserDashboardPage.tsx'


createRoot(document.getElementById('root')!).render(
  <MantineProvider>
      <StrictMode>
        <BrowserRouter>
          <Routes>
            {/* <Route path="/" element={<ViewUsersPage />} /> */}
            <Route path="/" element={<UserDashboardPage />} />
            
            {/* <Route path="/" element={<FintechDashboard />} /> */}
          </Routes>
        </BrowserRouter>
  </StrictMode>,
  </MantineProvider>

)
