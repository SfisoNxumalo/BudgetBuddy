import { useEffect, useState } from 'react';
import './App.css';
import { Input } from '@mantine/core';
import '@mantine/core/styles.css';
import { IconAt } from '@tabler/icons-react';

function App() {

    return (
        
         <>
            <Input size="md" radius="md" placeholder="Input component" />
            <Input placeholder="Your email" leftSection={<IconAt size={16} />} />
         </>
    );
}

export default App;